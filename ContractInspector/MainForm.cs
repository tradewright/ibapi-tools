﻿#region License

// The MIT License (MIT)
//
// Copyright (c) 2019 Richard L King (TradeWright Software Systems)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#endregion

using IBApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractInspector
{
    public partial class MainForm : Form {

        #region enums

        internal enum ConnectionState {
            Disconnected,
            Connecting,
            Connected
        }

        #endregion

        #region Constants

        // Set this constant to the name of the computer where TWS is running. If it's running on this computer, leave it blank.
        private const string TWSHostName = "";

        // Set this constant to the port used for communicating with TWS. The default value is 7496, but may be changed in the TWS
        //Global Configuration dialog.
        private const int Port = 7496;

        // The client id distinguishes this API connection from other connections. Don't use 0, as this has a special meaning
        // and can cause problems. Otherwise the actual value is not significant. If you have more than one program connecting to
        // the API at the same time, you must use different client ids in each one.
        private const int ClientId = 1219445327;

        // We use ids above this value for market depth requests, so that we can tell which error messages from TWS
        // relate to them rather than other things with ids
        private const int MinimumMarketDepthId = 16777216;

        private const string ContractColumnId = "ContractId";
        private const string ContractColumnType = "ContractSecType";
        private const string ContractColumnSymbol = "ContractSymbol";
        private const string ContractColumnLocalSymbol = "ContractLocalSymbol";
        private const string ContractColumnTradingClass = "ContractTradingClass";
        private const string ContractColumnExpiry = "ContractExpiry";
        private const string ContractColumnExchange = "ContractExchange";
        private const string ContractColumnPrimaryExchange = "ContractPrimaryExchange";
        private const string ContractColumnCurrency = "ContractCurrency";
        private const string ContractColumnStrike = "ContractStrike";
        private const string ContractColumnRight = "ContractRight";
        private const string ContractColumnMultiplier = "ContractMultiplier";

        private const string TickerColumnAsk = "Ask";
        private const string TickerColumnAskSize = "AskSize";
        private const string TickerColumnBid = "Bid";
        private const string TickerColumnBidSize = "BidSize";
        private const string TickerColumnClose = "Close";
        private const string TickerColumnHigh = "High";
        private const string TickerColumnLast = "Last";
        private const string TickerColumnLastSize = "LastSize";
        private const string TickerColumnLow = "Low";
        private const string TickerColumnOpen = "Open";
        private const string TickerColumnSymbol = "Symbol";
        private const string TickerColumnVolume = "Volume";

        #endregion

        #region Fields

        // Records whether there is currently a connection to the API server
        private ConnectionState mConnectionState = ConnectionState.Disconnected;

        // For each ticker, this array stores information about it.
        private List<Ticker> mTickers = new List<Ticker>();

        //This will be incremented for each ticker started. It is used as an index into mTickerGridRows
        private int mNextTickerId;

        // For each market depth stream, this array stores information about it.
        private List<Ticker> mDOMTickers = new List<Ticker>();

        // This will be incremented for each market depth started
        private int mNextDOMTickerId = MinimumMarketDepthId;

        //Used internally by the API
        private EReaderSignal mSignal = new EReaderMonitorSignal();

        //Provides methods to invoke TWS functionality
        private EClientSocket mApi;

        //maintains the market depth model, and updates the market depth displays
        private MarketDepthManager mDepthMgr;

        private ContractFetcher mContractFetcher;

        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);

        #endregion

        #region Constructor

        public MainForm() {
            mApi = new EClientSocket((EWrapper)new ApiEventSource(this, SynchronizationContext.Current), mSignal);
            InitializeComponent();
            this.Text = $"Contract Inspector v{Application.ProductVersion}";
        }

        #endregion

        #region Form Event Handlers

        protected override void OnClosing(CancelEventArgs e) {
            if (mConnectionState != ConnectionState.Disconnected) disconnectFromTWS();
            base.OnClosing(e);
        }

        protected override void OnLoad(EventArgs e) {
            mDepthMgr = new MarketDepthManager(BidGrid, AskGrid);

            ServerTextBox.Text = TWSHostName;
            PortTextBox.Text = Port.ToString();
            ClientIdTextBox.Text = ClientId.ToString();

            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e) {
            setConnectionState(ConnectionState.Disconnected);
            base.OnShown(e);
        }

        #endregion

        #region Form Controls Event Handlers

        private void ClientIdTextBox_Validating(object sender, CancelEventArgs e) {
            e.Cancel = !validate(this, ClientIdTextBox, validateClientId);
        }

        private void ConnectDisconnectButton_Click(object sender, EventArgs e) {
            if (mConnectionState == ConnectionState.Disconnected) {
                connectToTWS();
            } else {
                disconnectFromTWS();
            }
        }

        private void ConIdText_Validating(object sender, CancelEventArgs e) {
            e.Cancel = !validate(this, ConIdText, validateContractId);
        }

        private void ContractGrid_SelectionChanged(object sender, EventArgs e) {
            StartTickersButton.Enabled = (ContractGrid.SelectedRows.Count > 0);
            StartSnapshotsButton.Enabled = (ContractGrid.SelectedRows.Count > 0);
            StartMarketDepthButton.Enabled = (ContractGrid.SelectedRows.Count == 1);
        }

        private void PortTextBox_Validating(object sender, CancelEventArgs e) {
            e.Cancel = !validate(this, PortTextBox, validatePort);
        }

        private async void ReqContractDetailsButton_Click(object sender, EventArgs e) {
            ContractGrid.Rows.Clear();

            var contract = new Contract() {
                ConId = int.Parse(ConIdText.Text),
                Currency = CurrencyText.Text,
                Exchange = ExchangeText.Text,
                IncludeExpired = int.Parse(IncludeExpiredText.Text) != 0,
                LastTradeDateOrContractMonth = LastTradeDateOrContractMonthText.Text,
                LocalSymbol = LocalSymbolText.Text,
                Multiplier = MultiplierText.Text,
                PrimaryExch = PrimaryExchangeText.Text,
                Right = RightText.Text,
                SecId = SecIdText.Text,
                SecIdType = SecIdTypeCombo.SelectedItem?.ToString(),
                SecType = SecTypeCombo.SelectedItem?.ToString(),
                Strike = double.Parse(StrikeText.Text),
                Symbol = SymbolText.Text,
                TradingClass = TradingClassText.Text
            };

            mContractFetcher = new ContractFetcher();
            mContractFetcher.ContractFetchProgress += (s, ev) => {
                ContractFetchStatusLabel.Text = ev.Status;
                var suff = ev.NumberOfContracts > 1 ? "s" : "";
                ContractsCountLabel.Text = $"{ev.NumberOfContracts} contract{suff}";
                ContractFetchProgressBar.Value = (int)ev.PercentComplete;
            };
            ContractFetchStatusLabel.Visible = true;
            ContractsCountLabel.Visible = true;
            ContractFetchProgressBar.Visible = true;

            TabControl1.SelectedTab = ContractsTabPage;
            this.UseWaitCursor = true;
            var contractDetailsList = await mContractFetcher.FetchContractsAsync(mApi, contract);
            mContractFetcher = null;

            if (contractDetailsList.Count != 0) {
                ContractGrid.Rows.Add(contractDetailsList.Count);

                for (int i = 0; i < contractDetailsList.Count; i++) {
                    var row = ContractGrid.Rows[i];
                    row.Tag = contractDetailsList[i];
                    var c = contractDetailsList[i].Contract;

                    showContractValue(row, ContractColumnId, c.ConId.ToString());
                    showContractValue(row, ContractColumnCurrency, c.Currency);
                    showContractValue(row, ContractColumnExchange, c.Exchange);
                    showContractValue(row, ContractColumnPrimaryExchange, c.PrimaryExch);
                    showContractValue(row, ContractColumnExpiry, c.LastTradeDateOrContractMonth);
                    showContractValue(row, ContractColumnLocalSymbol, c.LocalSymbol.Replace(" ", "\u00B7"));
                    showContractValue(row, ContractColumnMultiplier, c.Multiplier);
                    showContractValue(row, ContractColumnRight, c.Right);
                    showContractValue(row, ContractColumnType, c.SecType);
                    showContractValue(row, ContractColumnStrike, c.Strike.ToString());
                    showContractValue(row, ContractColumnSymbol, c.Symbol);
                    showContractValue(row, ContractColumnTradingClass, c.TradingClass);
                }
                ContractGrid.ClearSelection();
            }

            ContractFetchStatusLabel.Visible = false;
            ContractFetchProgressBar.Visible = false;

            this.UseWaitCursor = false;
        }

        private void StartMarketDepthButton_Click(object sender, EventArgs e) {
            if (mDepthMgr.InProgress)
                stopMarketDepth();
            var cd = (ContractDetails)ContractGrid.SelectedRows[0].Tag;
            mDepthMgr.Initialise(20, cd.Contract.SecType, cd.MinTick * cd.PriceMagnifier);
            startMarketDepth(cd);
            StopMarketDepthButton.Enabled = true;
            TabControl1.SelectedTab = MarketDepthTabPage;
        }

        private async void StartSnapshotsButton_Click(object sender, EventArgs e) {
            await startTickersAsync(true);
        }

        private async void StartTickersButton_Click(object sender, EventArgs e) {
            await startTickersAsync(false);
        }

        private void StopMarketDepthButton_Click(object sender, EventArgs e) {
            stopMarketDepth();
        }

        private void StopTickersButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in TickerGrid.SelectedRows) {
                if (row.Tag != null)
                    stopTicker((int)row.Tag);
            }
            StopTickersButton.Enabled = false;
        }

        private void StrikeText_Validating(object sender, CancelEventArgs e) {
            e.Cancel = !validate(this, StrikeText, validateStrike);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void TickerGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            StopTickersButton.Enabled = false;
        }

        private void TickerGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            StopTickersButton.Enabled = false;
            foreach (DataGridViewRow row in (BaseCollection)TickerGrid.SelectedRows) {
                if (row.Tag != null) {
                    StopTickersButton.Enabled = true;
                    break;
                }
            }
        }

        private void TickerGrid_SelectionChanged(object sender, EventArgs e) {
            StopTickersButton.Enabled = (TickerGrid.SelectedRows.Count > 0);
        }

        #endregion

        #region TWS API Event Handlers

        internal void connectAck() {
            setConnectionState(ConnectionState.Connected);
            logMessage("Connected ok");
            ConIdText.Focus();
            ReqContractDetailsButton.Enabled = true;
            this.AcceptButton = ReqContractDetailsButton;
            mApi.reqCurrentTime();
        }

        internal void connectionClosed() {
            setConnectionState(ConnectionState.Disconnected);
            logMessage("Disconnected from TWS");
        }

        internal void contractDetails(int reqId, ContractDetails contractData) {
            mContractFetcher.AddContractDetails(contractData);
        }

        internal void contractDetailsEnd(int reqId) {
            mContractFetcher.EndContractDetails();
        }

        internal void currentTime(long time) {
            logMessage($"currentTime: {UnixTimestampToDate(time)}");
        }

        internal void error(Exception e) {
            logMessage($"An exception has occurred: {e.ToString()}");
            this.UseWaitCursor = false;
            if (mConnectionState == ConnectionState.Connecting)
                setConnectionState(ConnectionState.Disconnected);
        }

        internal void error(string str) {
            logMessage($"Message from TWS: message={str}");
            this.UseWaitCursor = false;
        }

        internal void error(int id, int errorCode, string errorMsg) {
            logMessage($"Message from TWS: code={errorCode}; id={id}; message={errorMsg}");
            if (mContractFetcher != null)
                mContractFetcher.error(id);
            this.UseWaitCursor = false;
        }

        internal void managedAccounts(string accountsList) {
            logMessage("Managed accounts: " + accountsList);
        }

        internal void tickGeneric(int tickerId, TickType field, double value) {
            if (mTickers[tickerId]?.ContractDetails == null)
                // the market data stream has been stopped but this
                // update was already on its way
                return;
            logMessage($"tickGeneric: id={tickerId}; field={getField(field)}; value={value}");
        }

        public void tickPrice(int tickerId, TickType field, double price, TickAttrib attribs) {
            if (mTickers[tickerId]?.ContractDetails == null)
                // the market data stream has been stopped but this
                // update was already on its way
                return;

            var formatPrice = mTickers[tickerId].FormatPrice;
            switch (field) {
            case TickType.Ask:
                showTickerValue(tickerId, TickerColumnAsk, formatPrice(price));
                break;
            case TickType.Bid:
                showTickerValue(tickerId, TickerColumnBid, formatPrice(price));
                break;
            case TickType.Last:
                showTickerValue(tickerId, TickerColumnLast, formatPrice(price));
                break;
            case TickType.Open:
                showTickerValue(tickerId, TickerColumnOpen, formatPrice(price));
                break;
            case TickType.High:
                showTickerValue(tickerId, TickerColumnHigh, formatPrice(price));
                break;
            case TickType.Low:
                showTickerValue(tickerId, TickerColumnLow, formatPrice(price));
                break;
            case TickType.Close:
                showTickerValue(tickerId, TickerColumnClose, formatPrice(price));
                break;
            default:
                logMessage($"tickPrice: id={tickerId}; field={getField(field)}; value={formatPrice(price)}");
                break;
            }
        }

        internal void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions) {
            logMessage($"tickReqParams: id={tickerId}; minTick={minTick}; bboExchange={bboExchange}; snapshotPermissions={snapshotPermissions}");
        }

        internal void tickSize(int tickerId, TickType field, decimal size) {
            if (mTickers[tickerId]?.ContractDetails == null)
                // the market data stream has been stopped but this
                // update was already on its way
                return;
            switch (field) {
            case TickType.AskSize:
                showTickerValue(tickerId, TickerColumnAskSize, size.ToString());
                break;
            case TickType.BidSize:
                showTickerValue(tickerId, TickerColumnBidSize, size.ToString());
                break;
            case TickType.LastSize:
                showTickerValue(tickerId, TickerColumnLastSize, size.ToString());
                break;
            case TickType.Volume:
                showTickerValue(tickerId, TickerColumnVolume, size.ToString());
                break;
            default:
                logMessage($"tickSize: id={tickerId}; field={getField(field)}; value={size}");
                break;
            }
        }

        internal void tickSnapshotEnd(int tickerId) {
            if (mTickers[tickerId]?.ContractDetails == null)
                // the market data stream has been stopped but this
                // update was already on its way
                return;
            logMessage($"tickSnapshotEnd: id={tickerId}");
        }

        internal void tickString(int tickerId, TickType field, string value) {
            if (mTickers[tickerId]?.ContractDetails == null)
                // the market data stream has been stopped but this
                // update was already on its way
                return;
            switch (field) {
            case TickType.LastTimestamp:
                value = UnixTimestampToDate(long.Parse(value)).ToString("yyyy-MM-dd hh:mm:ss");
                break;
            }
            logMessage($"tickString: id={tickerId}; field={getField(field)}; value={value}");
        }

        internal void updateMktDepth(int tickerId, int position, string marketMaker, int operation, int side, double price, decimal size, bool isSmartDepth) {
            if (mDOMTickers[tickerId - MinimumMarketDepthId]?.ContractDetails == null)
                // the market depth stream has been stopped but this
                // update was already on its way
                return;
            mDepthMgr.UpdateMktDepth(tickerId, position, marketMaker, (MarketDepthManager.OperationType)operation, (MarketDepthManager.Side)side, price, size);
        }

        #endregion

        #region Helper Methods

        private void connectToTWS() {
            logMessage("Connecting to TWS");
            setConnectionState(ConnectionState.Connecting);
            // this ensures the state changes are visible: otherwise the synchronous connection mechanism
            // blocks them until it's finished
            ConnectionPanel.Refresh();

            mApi.eConnect(ServerTextBox.Text, int.Parse(PortTextBox.Text), int.Parse(ClientIdTextBox.Text), false);

            // the following causes the IB API to start processing messages 
            //  received From TWS

            Task task = new Task((Action)(() => {
                EReader ereader = new EReader(mApi, mSignal);

                ereader.Start();

                while (mApi.IsConnected()) {
                    mSignal.waitForSignal();
                    ereader.processMsgs();
                }
            }), TaskCreationOptions.LongRunning);
            if (mApi.ServerVersion > 0)
                task.Start();
        }

        private string contractToString(Contract contract) {
            return $"secType={contract.SecType}; localSymbol={contract.LocalSymbol.Replace(" ", "\u00B7")}; exchange={contract.Exchange}; currency={contract.Currency}";
        }

        private void disconnectFromTWS() {
            logMessage("Disconnecting from TWS");

            stopAllTickers();
            stopMarketDepth();

            setConnectionState(ConnectionState.Disconnected);
            mApi.eDisconnect();

            ReqContractDetailsButton.Enabled = false;

            ContractGrid.Rows.Clear();
        }

        private void ensureTickerGridRowExists(int tickerId) {
            if (mTickers[tickerId].GridRow != null)
                return;
            var row = TickerGrid.Rows[TickerGrid.Rows.Add()];
            row.Tag = (object)tickerId;
            mTickers[tickerId].GridRow = row;
            showTickerValue(tickerId, TickerColumnSymbol, mTickers[tickerId].ContractDetails.Contract.LocalSymbol.Replace(" ", "\u00B7"));
        }

        private string getField(TickType field) => Enum.GetName(typeof(TickType), field);

        private void logMessage(string pMsg)
        {
            if (!LogText.IsDisposed)
                LogText.AppendText($"{ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}  {pMsg}\r\n");
        }

        private void setConnectionState(ConnectionState state) {
            mConnectionState = state;
            switch (mConnectionState) {
            case ConnectionState.Disconnected:
                ConnectionPanel.BackColor = Color.MistyRose;
                ConnectionStatusLabel.Text = "Not connected";
                ConnectionStatusLabel.ForeColor = Color.Red;
                ConnectDisconnectButton.Enabled = true;
                ConnectDisconnectButton.Text = "Connect";
                ServerTextBox.Focus();
                break;
            case ConnectionState.Connecting:
                ConnectionPanel.BackColor = Color.FromArgb(251, 227, 80);
                ConnectionStatusLabel.Text = "Connecting...";
                ConnectionStatusLabel.ForeColor = Color.FromArgb(255, 178, 82);
                ConnectDisconnectButton.Enabled = false;
                break;
            case ConnectionState.Connected:
                ConnectionPanel.BackColor = Color.FromArgb(179, 230, 179);
                ConnectionStatusLabel.Text = "Connected";
                ConnectionStatusLabel.ForeColor = Color.FromArgb(19, 146, 18);
                ConnectDisconnectButton.Enabled = true;
                ConnectDisconnectButton.Text = "Disconnect";
                break;
            }
        }

        private void showContractValue(DataGridViewRow row, string columnName, string value) {
            row.Cells[columnName].Value = value;
        }

        private void showTickerValue(int tickerId, string columnName, string value)
        {
            if (mTickers[tickerId] == null)
                // the ticker has been stopped, but this tick was already on its way,
                // so just ignore it
                return;
    
            ensureTickerGridRowExists(tickerId);
            mTickers[tickerId].GridRow.Cells[columnName].Value = value;
        }

        private void startMarketDepth(ContractDetails contractData)
        {
            var id = mNextDOMTickerId++;
            logMessage($"Starting market depth: id={id}; {contractToString(contractData.Contract)}");
            mApi.reqMarketDepth(id, contractData.Contract, 20, false, null);
            Ticker ticker = new Ticker(contractData);
            mDOMTickers.Add(ticker);
        }

        private void startMarketData(ContractDetails contractData, bool snapshot)
        {
            var id = mNextTickerId++;
            logMessage($"Starting ticker: id={id}; {contractToString(contractData.Contract)}");

            mApi.reqMktData(id, contractData.Contract, "", snapshot, false, null);
            Ticker ticker = new Ticker(contractData) {
                ContractDetails = contractData,
                FormatPrice = PriceFormatter.GetPriceFormatter(contractData.Contract.SecType, contractData.MinTick * contractData.PriceMagnifier),
                IsSnapshot = true
            };
            mTickers.Add(ticker);
        }

        private async Task startTickersAsync(bool snapshot) {
            var selectedContractDetails = new List<ContractDetails>();
            foreach (DataGridViewRow row in ContractGrid.SelectedRows) {
                selectedContractDetails.Add((ContractDetails)row.Tag);
            }
            selectedContractDetails.Sort(new ContractDetailsComparer());

            TabControl1.SelectedTab = TickersTabPage;
            TickerGrid.ClearSelection();

            foreach (ContractDetails contractData in selectedContractDetails) {
                startMarketData(contractData, snapshot);
                await Task.Delay(12);
            }

        }
        private void stopAllTickers()
        {
            logMessage("Stopping all tickers");
            for (int i = 0; i < mNextTickerId; i++) {
                if (mTickers[i] != null)
                    stopTicker(i);
            }
            TickerGrid.Rows.Clear();
        }

        private void stopMarketDepth()
        {
            StopMarketDepthButton.Enabled = false;

            if (!mDepthMgr.InProgress)
                return;

            var marketDepthIndex = mNextDOMTickerId - 1 - MinimumMarketDepthId;

            if (mDOMTickers[marketDepthIndex] == null)
                return;

            var id = mNextDOMTickerId - 1;
            logMessage($"Stopping market depth: id={id}; {contractToString(mDOMTickers[marketDepthIndex].ContractDetails.Contract)}");
            mApi.cancelMktDepth(id, false);

            mDOMTickers[marketDepthIndex] = null;
            mDepthMgr.Clear();
        }

        private void stopTicker(int tickerId)
        {
            logMessage($"Stopping ticker: id={tickerId}; {contractToString(mTickers[tickerId].ContractDetails.Contract)}");

            if (!mTickers[tickerId].IsSnapshot)
                mApi.cancelMktData(tickerId);

            mTickers[tickerId].ContractDetails = null;
            if (mTickers[tickerId].GridRow != null) TickerGrid.Rows.Remove(mTickers[tickerId].GridRow);
            mTickers[tickerId].GridRow = null;
            mTickers[tickerId] = null;
        }

        public static DateTime UnixTimestampToDate(long seconds) => UnixEpoch.AddSeconds(Convert.ToDouble(seconds));

        internal delegate bool Validator(out string errMsg);
        private bool validate(MainForm instance, Control c, Validator v) {
            if (!v(out string errMsg)) {
                ErrorProvider.SetIconAlignment(c, ErrorIconAlignment.BottomLeft);
                ErrorProvider.SetError(c, errMsg);
                return false;
            } else {
                ErrorProvider.SetError(c, "");
                return true;
            }
        }

        private bool validateClientId(out string errorMessage) {
            if (!int.TryParse(ClientIdTextBox.Text, out int clientId)) {
                errorMessage = "ClientId must be a number";
                return false;
            } else if (clientId < 0) {
                errorMessage = "ClientId must not be less than 0";
                return false;
            } else {
                errorMessage = "";
                return true;
            }
        }

        private bool validateContractId(out string errorMessage) {
            if (!int.TryParse(ConIdText.Text, out int conId)) {
                errorMessage = "Value must be an integer";
                return false;
            } else if (conId < 0) {
                errorMessage = "Value cannot be negative";
                return false;
            } else {
                errorMessage = "";
                return true;
            }
        }

        private bool validatePort(out string errorMessage) {
            if (!int.TryParse(PortTextBox.Text, out int port)) {
                errorMessage = "Port must be a number";
                return false;
            } else if (port < 1027) {
                errorMessage = "Port must not be less than 0";
                return false;
            } else {
                errorMessage = "";
                return true;
            }
        }

        private bool validateStrike(out string errorMessage) {
            if (!double.TryParse(StrikeText.Text, out double strike)) {
                errorMessage = "Strike must be a number";
                return false;
            } else if (strike < 0) {
                errorMessage = "Strike must not be less than 0";
                return false;
            } else {
                errorMessage = "";
                return true;
            }
        }

        #endregion

    }

}
