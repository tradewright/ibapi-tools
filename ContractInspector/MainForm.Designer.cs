using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ContractInspector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogText = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StartMarketDepthButton = new System.Windows.Forms.Button();
            this.StartTickersButton = new System.Windows.Forms.Button();
            this.StartSnapshotsButton = new System.Windows.Forms.Button();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ReqContractDetailsButton = new System.Windows.Forms.Button();
            this.ContractSpecifierPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.SecIdTypeCombo = new System.Windows.Forms.ComboBox();
            this.Label58 = new System.Windows.Forms.Label();
            this.SecTypeCombo = new System.Windows.Forms.ComboBox();
            this.Label55 = new System.Windows.Forms.Label();
            this.TradingClassText = new System.Windows.Forms.TextBox();
            this.Label54 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.SecIdText = new System.Windows.Forms.TextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.IncludeExpiredText = new System.Windows.Forms.TextBox();
            this.SymbolText = new System.Windows.Forms.TextBox();
            this.Label39 = new System.Windows.Forms.Label();
            this.LastTradeDateOrContractMonthText = new System.Windows.Forms.TextBox();
            this.LocalSymbolText = new System.Windows.Forms.TextBox();
            this.StrikeText = new System.Windows.Forms.TextBox();
            this.CurrencyText = new System.Windows.Forms.TextBox();
            this.ExchangeText = new System.Windows.Forms.TextBox();
            this.Label56 = new System.Windows.Forms.Label();
            this.RightText = new System.Windows.Forms.TextBox();
            this.Label57 = new System.Windows.Forms.Label();
            this.PrimaryExchangeText = new System.Windows.Forms.TextBox();
            this.MultiplierText = new System.Windows.Forms.TextBox();
            this.ConIdText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.ContractsTabPage = new System.Windows.Forms.TabPage();
            this.ContractFetchProgressBar = new System.Windows.Forms.ProgressBar();
            this.ContractFetchStatusLabel = new System.Windows.Forms.Label();
            this.ContractsCountLabel = new System.Windows.Forms.Label();
            this.ContractGrid = new System.Windows.Forms.DataGridView();
            this.ContractId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractLocalSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractSecType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractTradingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractPrimaryExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStrike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TickersTabPage = new System.Windows.Forms.TabPage();
            this.StopTickersButton = new System.Windows.Forms.Button();
            this.TickerGrid = new System.Windows.Forms.DataGridView();
            this.MarketDepthTabPage = new System.Windows.Forms.TabPage();
            this.StopMarketDepthButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AskGrid = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidGrid = new System.Windows.Forms.DataGridView();
            this.MarketMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AveragePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ClientIdTextBox = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.ConnectDisconnectButton = new System.Windows.Forms.Button();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.ContractSpecifierPanel.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.ContractsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractGrid)).BeginInit();
            this.TickersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TickerGrid)).BeginInit();
            this.MarketDepthTabPage.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AskGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ConnectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogText
            // 
            this.LogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogText.BackColor = System.Drawing.Color.White;
            this.LogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogText.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogText.ForeColor = System.Drawing.Color.Gray;
            this.LogText.Location = new System.Drawing.Point(6, 6);
            this.LogText.Multiline = true;
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogText.Size = new System.Drawing.Size(1254, 280);
            this.LogText.TabIndex = 9;
            this.LogText.TabStop = false;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // StartMarketDepthButton
            // 
            this.StartMarketDepthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartMarketDepthButton.Enabled = false;
            this.StartMarketDepthButton.Location = new System.Drawing.Point(219, 585);
            this.StartMarketDepthButton.Name = "StartMarketDepthButton";
            this.StartMarketDepthButton.Size = new System.Drawing.Size(100, 35);
            this.StartMarketDepthButton.TabIndex = 24;
            this.StartMarketDepthButton.Text = "Start market depth";
            this.toolTip1.SetToolTip(this.StartMarketDepthButton, "Start market depth\r\nfor selected contract(s)");
            this.StartMarketDepthButton.UseVisualStyleBackColor = true;
            this.StartMarketDepthButton.Click += new System.EventHandler(this.StartMarketDepthButton_Click);
            // 
            // StartTickersButton
            // 
            this.StartTickersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartTickersButton.Enabled = false;
            this.StartTickersButton.Location = new System.Drawing.Point(6, 585);
            this.StartTickersButton.Name = "StartTickersButton";
            this.StartTickersButton.Size = new System.Drawing.Size(100, 35);
            this.StartTickersButton.TabIndex = 22;
            this.StartTickersButton.Text = "Start ticker(s)";
            this.toolTip1.SetToolTip(this.StartTickersButton, "Start realtime market data \r\nfor selected contract(s)");
            this.StartTickersButton.UseVisualStyleBackColor = true;
            this.StartTickersButton.Click += new System.EventHandler(this.StartTickersButton_Click);
            // 
            // StartSnapshotsButton
            // 
            this.StartSnapshotsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartSnapshotsButton.Enabled = false;
            this.StartSnapshotsButton.Location = new System.Drawing.Point(113, 585);
            this.StartSnapshotsButton.Name = "StartSnapshotsButton";
            this.StartSnapshotsButton.Size = new System.Drawing.Size(100, 35);
            this.StartSnapshotsButton.TabIndex = 23;
            this.StartSnapshotsButton.Text = "Start snapshot(s)";
            this.toolTip1.SetToolTip(this.StartSnapshotsButton, "Start realtime market data \r\nfor selected contract(s)");
            this.StartSnapshotsButton.UseVisualStyleBackColor = true;
            this.StartSnapshotsButton.Click += new System.EventHandler(this.StartSnapshotsButton_Click);
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.BackColor = System.Drawing.Color.PowderBlue;
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.BackColor = System.Drawing.Color.Azure;
            this.SplitContainer2.Panel1.Controls.Add(this.ReqContractDetailsButton);
            this.SplitContainer2.Panel1.Controls.Add(this.ContractSpecifierPanel);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.BackColor = System.Drawing.Color.Azure;
            this.SplitContainer2.Panel2.Controls.Add(this.TabControl1);
            this.SplitContainer2.Size = new System.Drawing.Size(1264, 648);
            this.SplitContainer2.SplitterDistance = 230;
            this.SplitContainer2.TabIndex = 20;
            // 
            // ReqContractDetailsButton
            // 
            this.ReqContractDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReqContractDetailsButton.Enabled = false;
            this.ReqContractDetailsButton.Location = new System.Drawing.Point(10, 606);
            this.ReqContractDetailsButton.Name = "ReqContractDetailsButton";
            this.ReqContractDetailsButton.Size = new System.Drawing.Size(95, 35);
            this.ReqContractDetailsButton.TabIndex = 78;
            this.ReqContractDetailsButton.Text = "Request contract details";
            this.ReqContractDetailsButton.UseVisualStyleBackColor = true;
            this.ReqContractDetailsButton.Click += new System.EventHandler(this.ReqContractDetailsButton_Click);
            // 
            // ContractSpecifierPanel
            // 
            this.ContractSpecifierPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractSpecifierPanel.AutoScroll = true;
            this.ContractSpecifierPanel.Controls.Add(this.label20);
            this.ContractSpecifierPanel.Controls.Add(this.SecIdTypeCombo);
            this.ContractSpecifierPanel.Controls.Add(this.Label58);
            this.ContractSpecifierPanel.Controls.Add(this.SecTypeCombo);
            this.ContractSpecifierPanel.Controls.Add(this.Label55);
            this.ContractSpecifierPanel.Controls.Add(this.TradingClassText);
            this.ContractSpecifierPanel.Controls.Add(this.Label54);
            this.ContractSpecifierPanel.Controls.Add(this.label24);
            this.ContractSpecifierPanel.Controls.Add(this.Label53);
            this.ContractSpecifierPanel.Controls.Add(this.SecIdText);
            this.ContractSpecifierPanel.Controls.Add(this.Label37);
            this.ContractSpecifierPanel.Controls.Add(this.label25);
            this.ContractSpecifierPanel.Controls.Add(this.label23);
            this.ContractSpecifierPanel.Controls.Add(this.label26);
            this.ContractSpecifierPanel.Controls.Add(this.label22);
            this.ContractSpecifierPanel.Controls.Add(this.IncludeExpiredText);
            this.ContractSpecifierPanel.Controls.Add(this.SymbolText);
            this.ContractSpecifierPanel.Controls.Add(this.Label39);
            this.ContractSpecifierPanel.Controls.Add(this.LastTradeDateOrContractMonthText);
            this.ContractSpecifierPanel.Controls.Add(this.LocalSymbolText);
            this.ContractSpecifierPanel.Controls.Add(this.StrikeText);
            this.ContractSpecifierPanel.Controls.Add(this.CurrencyText);
            this.ContractSpecifierPanel.Controls.Add(this.ExchangeText);
            this.ContractSpecifierPanel.Controls.Add(this.Label56);
            this.ContractSpecifierPanel.Controls.Add(this.RightText);
            this.ContractSpecifierPanel.Controls.Add(this.Label57);
            this.ContractSpecifierPanel.Controls.Add(this.PrimaryExchangeText);
            this.ContractSpecifierPanel.Controls.Add(this.MultiplierText);
            this.ContractSpecifierPanel.Controls.Add(this.ConIdText);
            this.ContractSpecifierPanel.Controls.Add(this.label21);
            this.ContractSpecifierPanel.Location = new System.Drawing.Point(0, 0);
            this.ContractSpecifierPanel.Name = "ContractSpecifierPanel";
            this.ContractSpecifierPanel.Size = new System.Drawing.Size(228, 600);
            this.ContractSpecifierPanel.TabIndex = 107;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(7, 9);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(73, 17);
            this.label20.TabIndex = 92;
            this.label20.Text = "Contract Id";
            // 
            // SecIdTypeCombo
            // 
            this.SecIdTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecIdTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SecIdTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SecIdTypeCombo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.SecIdTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecIdTypeCombo.ForeColor = System.Drawing.Color.DimGray;
            this.SecIdTypeCombo.FormattingEnabled = true;
            this.SecIdTypeCombo.Items.AddRange(new object[] {
            "ISIN",
            "CUSIP"});
            this.SecIdTypeCombo.Location = new System.Drawing.Point(119, 328);
            this.SecIdTypeCombo.Name = "SecIdTypeCombo";
            this.SecIdTypeCombo.Size = new System.Drawing.Size(99, 21);
            this.SecIdTypeCombo.TabIndex = 89;
            // 
            // Label58
            // 
            this.Label58.BackColor = System.Drawing.Color.Transparent;
            this.Label58.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label58.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.ForeColor = System.Drawing.Color.DimGray;
            this.Label58.Location = new System.Drawing.Point(7, 180);
            this.Label58.Name = "Label58";
            this.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label58.Size = new System.Drawing.Size(73, 17);
            this.Label58.TabIndex = 99;
            this.Label58.Text = "Exchange";
            // 
            // SecTypeCombo
            // 
            this.SecTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SecTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SecTypeCombo.BackColor = System.Drawing.Color.Gainsboro;
            this.SecTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecTypeCombo.ForeColor = System.Drawing.Color.DimGray;
            this.SecTypeCombo.FormattingEnabled = true;
            this.SecTypeCombo.Items.AddRange(new object[] {
            "",
            "STK",
            "OPT",
            "FUT",
            "IND",
            "FOP",
            "CASH",
            "BAG",
            "WAR",
            "BOND",
            "CMDTY",
            "NEWS",
            "FUND"});
            this.SecTypeCombo.Location = new System.Drawing.Point(119, 35);
            this.SecTypeCombo.Name = "SecTypeCombo";
            this.SecTypeCombo.Size = new System.Drawing.Size(99, 21);
            this.SecTypeCombo.TabIndex = 78;
            // 
            // Label55
            // 
            this.Label55.BackColor = System.Drawing.Color.Transparent;
            this.Label55.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label55.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.ForeColor = System.Drawing.Color.DimGray;
            this.Label55.Location = new System.Drawing.Point(7, 270);
            this.Label55.Name = "Label55";
            this.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label55.Size = new System.Drawing.Size(73, 17);
            this.Label55.TabIndex = 97;
            this.Label55.Text = "Right";
            // 
            // TradingClassText
            // 
            this.TradingClassText.AcceptsReturn = true;
            this.TradingClassText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TradingClassText.BackColor = System.Drawing.Color.Gainsboro;
            this.TradingClassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TradingClassText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TradingClassText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradingClassText.ForeColor = System.Drawing.Color.DimGray;
            this.TradingClassText.Location = new System.Drawing.Point(119, 106);
            this.TradingClassText.MaxLength = 0;
            this.TradingClassText.Name = "TradingClassText";
            this.TradingClassText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TradingClassText.Size = new System.Drawing.Size(99, 13);
            this.TradingClassText.TabIndex = 81;
            this.TradingClassText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label54
            // 
            this.Label54.BackColor = System.Drawing.Color.Transparent;
            this.Label54.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label54.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label54.ForeColor = System.Drawing.Color.DimGray;
            this.Label54.Location = new System.Drawing.Point(7, 199);
            this.Label54.Name = "Label54";
            this.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label54.Size = new System.Drawing.Size(97, 17);
            this.Label54.TabIndex = 100;
            this.Label54.Text = "Primary Exchange";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(7, 106);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label24.Size = new System.Drawing.Size(73, 17);
            this.label24.TabIndex = 103;
            this.label24.Text = "Trading Class";
            // 
            // Label53
            // 
            this.Label53.BackColor = System.Drawing.Color.Transparent;
            this.Label53.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label53.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.ForeColor = System.Drawing.Color.DimGray;
            this.Label53.Location = new System.Drawing.Point(7, 299);
            this.Label53.Name = "Label53";
            this.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label53.Size = new System.Drawing.Size(73, 17);
            this.Label53.TabIndex = 98;
            this.Label53.Text = "Multiplier";
            // 
            // SecIdText
            // 
            this.SecIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecIdText.BackColor = System.Drawing.Color.Gainsboro;
            this.SecIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecIdText.ForeColor = System.Drawing.Color.DimGray;
            this.SecIdText.Location = new System.Drawing.Point(119, 355);
            this.SecIdText.Name = "SecIdText";
            this.SecIdText.Size = new System.Drawing.Size(99, 13);
            this.SecIdText.TabIndex = 90;
            this.SecIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label37
            // 
            this.Label37.BackColor = System.Drawing.Color.Transparent;
            this.Label37.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label37.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.ForeColor = System.Drawing.Color.DimGray;
            this.Label37.Location = new System.Drawing.Point(7, 38);
            this.Label37.Name = "Label37";
            this.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label37.Size = new System.Drawing.Size(73, 17);
            this.Label37.TabIndex = 94;
            this.Label37.Text = "Sec Type";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(7, 355);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 106;
            this.label25.Text = "Sec Id";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.label23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(7, 68);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 93;
            this.label23.Text = "Symbol";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.DimGray;
            this.label26.Location = new System.Drawing.Point(7, 331);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 105;
            this.label26.Text = "Sec Id Type";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(7, 252);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(73, 17);
            this.label22.TabIndex = 96;
            this.label22.Text = "Strike";
            // 
            // IncludeExpiredText
            // 
            this.IncludeExpiredText.AcceptsReturn = true;
            this.IncludeExpiredText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeExpiredText.BackColor = System.Drawing.Color.Gainsboro;
            this.IncludeExpiredText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncludeExpiredText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IncludeExpiredText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeExpiredText.ForeColor = System.Drawing.Color.DimGray;
            this.IncludeExpiredText.Location = new System.Drawing.Point(119, 392);
            this.IncludeExpiredText.MaxLength = 0;
            this.IncludeExpiredText.Name = "IncludeExpiredText";
            this.IncludeExpiredText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncludeExpiredText.Size = new System.Drawing.Size(99, 13);
            this.IncludeExpiredText.TabIndex = 91;
            this.IncludeExpiredText.Text = "0";
            // 
            // SymbolText
            // 
            this.SymbolText.AcceptsReturn = true;
            this.SymbolText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SymbolText.BackColor = System.Drawing.Color.Gainsboro;
            this.SymbolText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SymbolText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SymbolText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolText.ForeColor = System.Drawing.Color.DimGray;
            this.SymbolText.Location = new System.Drawing.Point(119, 68);
            this.SymbolText.MaxLength = 0;
            this.SymbolText.Name = "SymbolText";
            this.SymbolText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SymbolText.Size = new System.Drawing.Size(99, 13);
            this.SymbolText.TabIndex = 79;
            this.SymbolText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label39
            // 
            this.Label39.BackColor = System.Drawing.Color.Transparent;
            this.Label39.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label39.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.ForeColor = System.Drawing.Color.DimGray;
            this.Label39.Location = new System.Drawing.Point(7, 392);
            this.Label39.Name = "Label39";
            this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label39.Size = new System.Drawing.Size(88, 17);
            this.Label39.TabIndex = 104;
            this.Label39.Text = "Include Expired";
            // 
            // LastTradeDateOrContractMonthText
            // 
            this.LastTradeDateOrContractMonthText.AcceptsReturn = true;
            this.LastTradeDateOrContractMonthText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastTradeDateOrContractMonthText.BackColor = System.Drawing.Color.Gainsboro;
            this.LastTradeDateOrContractMonthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastTradeDateOrContractMonthText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastTradeDateOrContractMonthText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTradeDateOrContractMonthText.ForeColor = System.Drawing.Color.DimGray;
            this.LastTradeDateOrContractMonthText.Location = new System.Drawing.Point(119, 136);
            this.LastTradeDateOrContractMonthText.MaxLength = 0;
            this.LastTradeDateOrContractMonthText.Name = "LastTradeDateOrContractMonthText";
            this.LastTradeDateOrContractMonthText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastTradeDateOrContractMonthText.Size = new System.Drawing.Size(99, 13);
            this.LastTradeDateOrContractMonthText.TabIndex = 82;
            // 
            // LocalSymbolText
            // 
            this.LocalSymbolText.AcceptsReturn = true;
            this.LocalSymbolText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalSymbolText.BackColor = System.Drawing.Color.Gainsboro;
            this.LocalSymbolText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalSymbolText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocalSymbolText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalSymbolText.ForeColor = System.Drawing.Color.DimGray;
            this.LocalSymbolText.Location = new System.Drawing.Point(119, 87);
            this.LocalSymbolText.MaxLength = 0;
            this.LocalSymbolText.Name = "LocalSymbolText";
            this.LocalSymbolText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LocalSymbolText.Size = new System.Drawing.Size(99, 13);
            this.LocalSymbolText.TabIndex = 80;
            this.LocalSymbolText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // StrikeText
            // 
            this.StrikeText.AcceptsReturn = true;
            this.StrikeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrikeText.BackColor = System.Drawing.Color.Gainsboro;
            this.StrikeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StrikeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StrikeText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrikeText.ForeColor = System.Drawing.Color.DimGray;
            this.StrikeText.Location = new System.Drawing.Point(119, 252);
            this.StrikeText.MaxLength = 0;
            this.StrikeText.Name = "StrikeText";
            this.StrikeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StrikeText.Size = new System.Drawing.Size(99, 13);
            this.StrikeText.TabIndex = 86;
            this.StrikeText.Text = "0";
            this.StrikeText.Validating += new System.ComponentModel.CancelEventHandler(this.StrikeText_Validating);
            // 
            // CurrencyText
            // 
            this.CurrencyText.AcceptsReturn = true;
            this.CurrencyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyText.BackColor = System.Drawing.Color.Gainsboro;
            this.CurrencyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrencyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrencyText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyText.ForeColor = System.Drawing.Color.DimGray;
            this.CurrencyText.Location = new System.Drawing.Point(119, 225);
            this.CurrencyText.MaxLength = 0;
            this.CurrencyText.Name = "CurrencyText";
            this.CurrencyText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrencyText.Size = new System.Drawing.Size(99, 13);
            this.CurrencyText.TabIndex = 85;
            this.CurrencyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ExchangeText
            // 
            this.ExchangeText.AcceptsReturn = true;
            this.ExchangeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExchangeText.BackColor = System.Drawing.Color.Gainsboro;
            this.ExchangeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExchangeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExchangeText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeText.ForeColor = System.Drawing.Color.DimGray;
            this.ExchangeText.Location = new System.Drawing.Point(119, 180);
            this.ExchangeText.MaxLength = 0;
            this.ExchangeText.Name = "ExchangeText";
            this.ExchangeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExchangeText.Size = new System.Drawing.Size(99, 13);
            this.ExchangeText.TabIndex = 83;
            this.ExchangeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label56
            // 
            this.Label56.BackColor = System.Drawing.Color.Transparent;
            this.Label56.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label56.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.ForeColor = System.Drawing.Color.DimGray;
            this.Label56.Location = new System.Drawing.Point(7, 87);
            this.Label56.Name = "Label56";
            this.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label56.Size = new System.Drawing.Size(73, 17);
            this.Label56.TabIndex = 102;
            this.Label56.Text = "Local Symbol";
            // 
            // RightText
            // 
            this.RightText.AcceptsReturn = true;
            this.RightText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightText.BackColor = System.Drawing.Color.Gainsboro;
            this.RightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RightText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightText.ForeColor = System.Drawing.Color.DimGray;
            this.RightText.Location = new System.Drawing.Point(119, 270);
            this.RightText.MaxLength = 0;
            this.RightText.Name = "RightText";
            this.RightText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightText.Size = new System.Drawing.Size(99, 13);
            this.RightText.TabIndex = 87;
            this.RightText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label57
            // 
            this.Label57.BackColor = System.Drawing.Color.Transparent;
            this.Label57.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label57.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label57.ForeColor = System.Drawing.Color.DimGray;
            this.Label57.Location = new System.Drawing.Point(7, 225);
            this.Label57.Name = "Label57";
            this.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label57.Size = new System.Drawing.Size(73, 17);
            this.Label57.TabIndex = 101;
            this.Label57.Text = "Currency";
            // 
            // PrimaryExchangeText
            // 
            this.PrimaryExchangeText.AcceptsReturn = true;
            this.PrimaryExchangeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryExchangeText.BackColor = System.Drawing.Color.Gainsboro;
            this.PrimaryExchangeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrimaryExchangeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrimaryExchangeText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryExchangeText.ForeColor = System.Drawing.Color.DimGray;
            this.PrimaryExchangeText.Location = new System.Drawing.Point(119, 199);
            this.PrimaryExchangeText.MaxLength = 0;
            this.PrimaryExchangeText.Name = "PrimaryExchangeText";
            this.PrimaryExchangeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrimaryExchangeText.Size = new System.Drawing.Size(99, 13);
            this.PrimaryExchangeText.TabIndex = 84;
            this.PrimaryExchangeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // MultiplierText
            // 
            this.MultiplierText.AcceptsReturn = true;
            this.MultiplierText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplierText.BackColor = System.Drawing.Color.Gainsboro;
            this.MultiplierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiplierText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MultiplierText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplierText.ForeColor = System.Drawing.Color.DimGray;
            this.MultiplierText.Location = new System.Drawing.Point(119, 298);
            this.MultiplierText.MaxLength = 0;
            this.MultiplierText.Name = "MultiplierText";
            this.MultiplierText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MultiplierText.Size = new System.Drawing.Size(99, 13);
            this.MultiplierText.TabIndex = 88;
            // 
            // ConIdText
            // 
            this.ConIdText.AcceptsReturn = true;
            this.ConIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConIdText.BackColor = System.Drawing.Color.Gainsboro;
            this.ConIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConIdText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConIdText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConIdText.ForeColor = System.Drawing.Color.DimGray;
            this.ConIdText.Location = new System.Drawing.Point(119, 9);
            this.ConIdText.MaxLength = 0;
            this.ConIdText.Name = "ConIdText";
            this.ConIdText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConIdText.Size = new System.Drawing.Size(99, 13);
            this.ConIdText.TabIndex = 77;
            this.ConIdText.Text = "0";
            this.ConIdText.Validating += new System.ComponentModel.CancelEventHandler(this.ConIdText_Validating);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(7, 135);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(96, 32);
            this.label21.TabIndex = 95;
            this.label21.Text = "Last trade date or contract month";
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.ContractsTabPage);
            this.TabControl1.Controls.Add(this.TickersTabPage);
            this.TabControl1.Controls.Add(this.MarketDepthTabPage);
            this.TabControl1.HotTrack = true;
            this.TabControl1.Location = new System.Drawing.Point(-2, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1036, 650);
            this.TabControl1.TabIndex = 14;
            // 
            // ContractsTabPage
            // 
            this.ContractsTabPage.BackColor = System.Drawing.Color.Azure;
            this.ContractsTabPage.Controls.Add(this.StartSnapshotsButton);
            this.ContractsTabPage.Controls.Add(this.ContractFetchProgressBar);
            this.ContractsTabPage.Controls.Add(this.ContractFetchStatusLabel);
            this.ContractsTabPage.Controls.Add(this.ContractsCountLabel);
            this.ContractsTabPage.Controls.Add(this.StartMarketDepthButton);
            this.ContractsTabPage.Controls.Add(this.StartTickersButton);
            this.ContractsTabPage.Controls.Add(this.ContractGrid);
            this.ContractsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ContractsTabPage.Name = "ContractsTabPage";
            this.ContractsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ContractsTabPage.Size = new System.Drawing.Size(1028, 624);
            this.ContractsTabPage.TabIndex = 4;
            this.ContractsTabPage.Text = "Contracts";
            // 
            // ContractFetchProgressBar
            // 
            this.ContractFetchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractFetchProgressBar.ForeColor = System.Drawing.Color.PowderBlue;
            this.ContractFetchProgressBar.Location = new System.Drawing.Point(524, 595);
            this.ContractFetchProgressBar.Name = "ContractFetchProgressBar";
            this.ContractFetchProgressBar.Size = new System.Drawing.Size(400, 22);
            this.ContractFetchProgressBar.TabIndex = 34;
            this.ContractFetchProgressBar.Visible = false;
            // 
            // ContractFetchStatusLabel
            // 
            this.ContractFetchStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContractFetchStatusLabel.Location = new System.Drawing.Point(425, 595);
            this.ContractFetchStatusLabel.Name = "ContractFetchStatusLabel";
            this.ContractFetchStatusLabel.Size = new System.Drawing.Size(105, 22);
            this.ContractFetchStatusLabel.TabIndex = 33;
            this.ContractFetchStatusLabel.Text = "Fetching contracts";
            this.ContractFetchStatusLabel.Visible = false;
            // 
            // ContractsCountLabel
            // 
            this.ContractsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractsCountLabel.Location = new System.Drawing.Point(916, 595);
            this.ContractsCountLabel.Name = "ContractsCountLabel";
            this.ContractsCountLabel.Size = new System.Drawing.Size(106, 22);
            this.ContractsCountLabel.TabIndex = 32;
            this.ContractsCountLabel.Text = "100000 contracts";
            this.ContractsCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ContractsCountLabel.Visible = false;
            // 
            // ContractGrid
            // 
            this.ContractGrid.AllowUserToAddRows = false;
            this.ContractGrid.AllowUserToDeleteRows = false;
            this.ContractGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContractGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ContractGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContractGrid.BackgroundColor = System.Drawing.Color.White;
            this.ContractGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContractGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ContractGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContractGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ContractGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractId,
            this.ContractLocalSymbol,
            this.ContractSecType,
            this.ContractSymbol,
            this.ContractTradingClass,
            this.ContractExchange,
            this.ContractPrimaryExchange,
            this.ContractCurrency,
            this.ContractExpiry,
            this.ContractStrike,
            this.ContractRight,
            this.ContractMultiplier});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ContractGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.ContractGrid.EnableHeadersVisualStyles = false;
            this.ContractGrid.Location = new System.Drawing.Point(0, 0);
            this.ContractGrid.Name = "ContractGrid";
            this.ContractGrid.ReadOnly = true;
            this.ContractGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ContractGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContractGrid.Size = new System.Drawing.Size(1029, 582);
            this.ContractGrid.TabIndex = 12;
            this.ContractGrid.SelectionChanged += new System.EventHandler(this.ContractGrid_SelectionChanged);
            // 
            // ContractId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            this.ContractId.DefaultCellStyle = dataGridViewCellStyle3;
            this.ContractId.HeaderText = "Contract Id";
            this.ContractId.Name = "ContractId";
            this.ContractId.ReadOnly = true;
            // 
            // ContractLocalSymbol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ContractLocalSymbol.DefaultCellStyle = dataGridViewCellStyle4;
            this.ContractLocalSymbol.HeaderText = "Local Symbol";
            this.ContractLocalSymbol.Name = "ContractLocalSymbol";
            this.ContractLocalSymbol.ReadOnly = true;
            // 
            // ContractSecType
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ContractSecType.DefaultCellStyle = dataGridViewCellStyle5;
            this.ContractSecType.HeaderText = "Sec Type";
            this.ContractSecType.Name = "ContractSecType";
            this.ContractSecType.ReadOnly = true;
            // 
            // ContractSymbol
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ContractSymbol.DefaultCellStyle = dataGridViewCellStyle6;
            this.ContractSymbol.HeaderText = "Symbol";
            this.ContractSymbol.Name = "ContractSymbol";
            this.ContractSymbol.ReadOnly = true;
            // 
            // ContractTradingClass
            // 
            this.ContractTradingClass.HeaderText = "Trading Class";
            this.ContractTradingClass.Name = "ContractTradingClass";
            this.ContractTradingClass.ReadOnly = true;
            // 
            // ContractExchange
            // 
            this.ContractExchange.HeaderText = "Exchange";
            this.ContractExchange.Name = "ContractExchange";
            this.ContractExchange.ReadOnly = true;
            // 
            // ContractPrimaryExchange
            // 
            this.ContractPrimaryExchange.HeaderText = "Primary Exchange";
            this.ContractPrimaryExchange.Name = "ContractPrimaryExchange";
            this.ContractPrimaryExchange.ReadOnly = true;
            // 
            // ContractCurrency
            // 
            this.ContractCurrency.HeaderText = "Currency";
            this.ContractCurrency.Name = "ContractCurrency";
            this.ContractCurrency.ReadOnly = true;
            // 
            // ContractExpiry
            // 
            this.ContractExpiry.HeaderText = "Expiry";
            this.ContractExpiry.Name = "ContractExpiry";
            this.ContractExpiry.ReadOnly = true;
            // 
            // ContractStrike
            // 
            this.ContractStrike.HeaderText = "Strike";
            this.ContractStrike.Name = "ContractStrike";
            this.ContractStrike.ReadOnly = true;
            // 
            // ContractRight
            // 
            this.ContractRight.HeaderText = "Right";
            this.ContractRight.Name = "ContractRight";
            this.ContractRight.ReadOnly = true;
            // 
            // ContractMultiplier
            // 
            this.ContractMultiplier.HeaderText = "Multiplier";
            this.ContractMultiplier.Name = "ContractMultiplier";
            this.ContractMultiplier.ReadOnly = true;
            // 
            // TickersTabPage
            // 
            this.TickersTabPage.BackColor = System.Drawing.Color.Azure;
            this.TickersTabPage.Controls.Add(this.StopTickersButton);
            this.TickersTabPage.Controls.Add(this.TickerGrid);
            this.TickersTabPage.Location = new System.Drawing.Point(4, 22);
            this.TickersTabPage.Name = "TickersTabPage";
            this.TickersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TickersTabPage.Size = new System.Drawing.Size(1028, 624);
            this.TickersTabPage.TabIndex = 0;
            this.TickersTabPage.Text = "Tickers";
            // 
            // StopTickersButton
            // 
            this.StopTickersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopTickersButton.Enabled = false;
            this.StopTickersButton.Location = new System.Drawing.Point(6, 585);
            this.StopTickersButton.Name = "StopTickersButton";
            this.StopTickersButton.Size = new System.Drawing.Size(100, 35);
            this.StopTickersButton.TabIndex = 21;
            this.StopTickersButton.Text = "Stop selected ticker(s)";
            this.StopTickersButton.UseVisualStyleBackColor = true;
            this.StopTickersButton.Click += new System.EventHandler(this.StopTickersButton_Click);
            // 
            // TickerGrid
            // 
            this.TickerGrid.AllowUserToAddRows = false;
            this.TickerGrid.AllowUserToDeleteRows = false;
            this.TickerGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TickerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TickerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TickerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TickerGrid.BackgroundColor = System.Drawing.Color.White;
            this.TickerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TickerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TickerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TickerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TickerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TickerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.BidSize,
            this.BidPrice,
            this.LastPrice,
            this.LastSize,
            this.AskPrice,
            this.AskSize,
            this.Volume,
            this.HighPrice,
            this.LowPrice,
            this.Open,
            this.ClosePrice});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TickerGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.TickerGrid.EnableHeadersVisualStyles = false;
            this.TickerGrid.Location = new System.Drawing.Point(0, 0);
            this.TickerGrid.Name = "TickerGrid";
            this.TickerGrid.ReadOnly = true;
            this.TickerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TickerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TickerGrid.Size = new System.Drawing.Size(1028, 582);
            this.TickerGrid.TabIndex = 11;
            this.TickerGrid.SelectionChanged += new System.EventHandler(this.TickerGrid_SelectionChanged);
            // 
            // MarketDepthTabPage
            // 
            this.MarketDepthTabPage.BackColor = System.Drawing.Color.Azure;
            this.MarketDepthTabPage.Controls.Add(this.StopMarketDepthButton);
            this.MarketDepthTabPage.Controls.Add(this.TableLayoutPanel1);
            this.MarketDepthTabPage.Location = new System.Drawing.Point(4, 22);
            this.MarketDepthTabPage.Name = "MarketDepthTabPage";
            this.MarketDepthTabPage.Size = new System.Drawing.Size(809, 449);
            this.MarketDepthTabPage.TabIndex = 2;
            this.MarketDepthTabPage.Text = "Market Depth";
            this.MarketDepthTabPage.UseVisualStyleBackColor = true;
            // 
            // StopMarketDepthButton
            // 
            this.StopMarketDepthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopMarketDepthButton.Enabled = false;
            this.StopMarketDepthButton.Location = new System.Drawing.Point(6, 410);
            this.StopMarketDepthButton.Name = "StopMarketDepthButton";
            this.StopMarketDepthButton.Size = new System.Drawing.Size(100, 35);
            this.StopMarketDepthButton.TabIndex = 31;
            this.StopMarketDepthButton.Text = "Stop market depth";
            this.StopMarketDepthButton.UseVisualStyleBackColor = true;
            this.StopMarketDepthButton.Click += new System.EventHandler(this.StopMarketDepthButton_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.AskGrid, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.BidGrid, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(806, 407);
            this.TableLayoutPanel1.TabIndex = 13;
            // 
            // AskGrid
            // 
            this.AskGrid.AllowUserToAddRows = false;
            this.AskGrid.AllowUserToDeleteRows = false;
            this.AskGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AskGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.AskGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AskGrid.BackgroundColor = System.Drawing.Color.White;
            this.AskGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AskGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AskGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AskGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.AskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AskGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AskGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.AskGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AskGrid.EnableHeadersVisualStyles = false;
            this.AskGrid.Location = new System.Drawing.Point(406, 3);
            this.AskGrid.Name = "AskGrid";
            this.AskGrid.ReadOnly = true;
            this.AskGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AskGrid.RowHeadersVisible = false;
            this.AskGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AskGrid.Size = new System.Drawing.Size(397, 401);
            this.AskGrid.TabIndex = 14;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Market maker";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "Ask price";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText = "Ask size";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText = "Cum size";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle13.Format = "0.000000";
            this.DataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridViewTextBoxColumn8.HeaderText = "Avg price";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // BidGrid
            // 
            this.BidGrid.AllowUserToAddRows = false;
            this.BidGrid.AllowUserToDeleteRows = false;
            this.BidGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BidGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.BidGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BidGrid.BackgroundColor = System.Drawing.Color.White;
            this.BidGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BidGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BidGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BidGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.BidGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BidGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarketMaker,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn4,
            this.AveragePrice});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BidGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.BidGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BidGrid.EnableHeadersVisualStyles = false;
            this.BidGrid.Location = new System.Drawing.Point(3, 3);
            this.BidGrid.Name = "BidGrid";
            this.BidGrid.ReadOnly = true;
            this.BidGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BidGrid.RowHeadersVisible = false;
            this.BidGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BidGrid.Size = new System.Drawing.Size(397, 401);
            this.BidGrid.TabIndex = 13;
            // 
            // MarketMaker
            // 
            this.MarketMaker.HeaderText = "Market maker";
            this.MarketMaker.Name = "MarketMaker";
            this.MarketMaker.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "Bid price";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "Bid size";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Cum size";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // AveragePrice
            // 
            dataGridViewCellStyle17.Format = "0.000000";
            this.AveragePrice.DefaultCellStyle = dataGridViewCellStyle17;
            this.AveragePrice.HeaderText = "Avg price";
            this.AveragePrice.Name = "AveragePrice";
            this.AveragePrice.ReadOnly = true;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer1.BackColor = System.Drawing.Color.PowderBlue;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 40);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Azure;
            this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer2);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Azure;
            this.SplitContainer1.Panel2.Controls.Add(this.LogText);
            this.SplitContainer1.Size = new System.Drawing.Size(1264, 945);
            this.SplitContainer1.SplitterDistance = 648;
            this.SplitContainer1.TabIndex = 21;
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ConnectionPanel.Controls.Add(this.ConnectionStatusLabel);
            this.ConnectionPanel.Controls.Add(this.ClientIdTextBox);
            this.ConnectionPanel.Controls.Add(this.Label15);
            this.ConnectionPanel.Controls.Add(this.PortTextBox);
            this.ConnectionPanel.Controls.Add(this.Label14);
            this.ConnectionPanel.Controls.Add(this.ServerTextBox);
            this.ConnectionPanel.Controls.Add(this.Label13);
            this.ConnectionPanel.Controls.Add(this.ConnectDisconnectButton);
            this.ConnectionPanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(1264, 42);
            this.ConnectionPanel.TabIndex = 22;
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(146)))), ((int)(((byte)(18)))));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(1100, 5);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(152, 33);
            this.ConnectionStatusLabel.TabIndex = 28;
            this.ConnectionStatusLabel.Text = "Not connected";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientIdTextBox
            // 
            this.ClientIdTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientIdTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ClientIdTextBox.Location = new System.Drawing.Point(455, 15);
            this.ClientIdTextBox.Name = "ClientIdTextBox";
            this.ClientIdTextBox.Size = new System.Drawing.Size(66, 13);
            this.ClientIdTextBox.TabIndex = 2;
            this.ClientIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ClientIdTextBox_Validating);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(405, 15);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(44, 13);
            this.Label15.TabIndex = 27;
            this.Label15.Text = "ClientID";
            // 
            // PortTextBox
            // 
            this.PortTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PortTextBox.Location = new System.Drawing.Point(313, 15);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(66, 13);
            this.PortTextBox.TabIndex = 1;
            this.PortTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PortTextBox_Validating);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(281, 15);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(26, 13);
            this.Label14.TabIndex = 26;
            this.Label14.Text = "Port";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ServerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ServerTextBox.Location = new System.Drawing.Point(191, 15);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(66, 13);
            this.ServerTextBox.TabIndex = 0;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(127, 15);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(58, 13);
            this.Label13.TabIndex = 25;
            this.Label13.Text = "API Server";
            // 
            // ConnectDisconnectButton
            // 
            this.ConnectDisconnectButton.Location = new System.Drawing.Point(12, 9);
            this.ConnectDisconnectButton.Name = "ConnectDisconnectButton";
            this.ConnectDisconnectButton.Size = new System.Drawing.Size(71, 25);
            this.ConnectDisconnectButton.TabIndex = 3;
            this.ConnectDisconnectButton.Text = "Connect";
            this.ConnectDisconnectButton.UseVisualStyleBackColor = true;
            this.ConnectDisconnectButton.Click += new System.EventHandler(this.ConnectDisconnectButton_Click);
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // BidSize
            // 
            this.BidSize.HeaderText = "Bid Size";
            this.BidSize.Name = "BidSize";
            this.BidSize.ReadOnly = true;
            // 
            // Bid
            // 
            this.BidPrice.HeaderText = "Bid";
            this.BidPrice.Name = "Bid";
            this.BidPrice.ReadOnly = true;
            // 
            // Last
            // 
            this.LastPrice.HeaderText = "Last";
            this.LastPrice.Name = "Last";
            this.LastPrice.ReadOnly = true;
            // 
            // LastSize
            // 
            this.LastSize.HeaderText = "Last Size";
            this.LastSize.Name = "LastSize";
            this.LastSize.ReadOnly = true;
            // 
            // Ask
            // 
            this.AskPrice.HeaderText = "Ask";
            this.AskPrice.Name = "Ask";
            this.AskPrice.ReadOnly = true;
            // 
            // AskSize
            // 
            this.AskSize.HeaderText = "Ask Size";
            this.AskSize.Name = "AskSize";
            this.AskSize.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // High
            // 
            this.HighPrice.HeaderText = "High";
            this.HighPrice.Name = "High";
            this.HighPrice.ReadOnly = true;
            // 
            // Low
            // 
            this.LowPrice.HeaderText = "Low";
            this.LowPrice.Name = "Low";
            this.LowPrice.ReadOnly = true;
            // 
            // Open
            // 
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            // 
            // Close
            // 
            this.ClosePrice.HeaderText = "Prev Close";
            this.ClosePrice.Name = "Close";
            this.ClosePrice.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.ConnectDisconnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.ConnectionPanel);
            this.Controls.Add(this.SplitContainer1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IBAPI Contract Inspector";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.ContractSpecifierPanel.ResumeLayout(false);
            this.ContractSpecifierPanel.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.ContractsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractGrid)).EndInit();
            this.TickersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TickerGrid)).EndInit();
            this.MarketDepthTabPage.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AskGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidGrid)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TextBox LogText;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private ToolTip toolTip1;
        private SplitContainer SplitContainer2;
        private ComboBox SecIdTypeCombo;
        private ComboBox SecTypeCombo;
        public TextBox TradingClassText;
        public Label label24;
        internal TextBox SecIdText;
        internal Label label25;
        internal Label label26;
        public TextBox IncludeExpiredText;
        public Label Label39;
        public TextBox LocalSymbolText;
        public TextBox CurrencyText;
        public Label Label56;
        public Label Label57;
        public Label label20;
        public TextBox ConIdText;
        public Label label21;
        public TextBox MultiplierText;
        public TextBox PrimaryExchangeText;
        public TextBox RightText;
        public TextBox ExchangeText;
        public TextBox StrikeText;
        public TextBox LastTradeDateOrContractMonthText;
        public TextBox SymbolText;
        public Label label22;
        public Label label23;
        public Label Label37;
        public Label Label53;
        public Label Label54;
        public Label Label55;
        public Label Label58;
        private Button ReqContractDetailsButton;
        private TabControl TabControl1;
        private TabPage ContractsTabPage;
        private Button StartMarketDepthButton;
        private Button StartTickersButton;
        private DataGridView ContractGrid;
        private TabPage TickersTabPage;
        private Button StopTickersButton;
        private DataGridView TickerGrid;
        private TabPage MarketDepthTabPage;
        private Button StopMarketDepthButton;
        private TableLayoutPanel TableLayoutPanel1;
        private DataGridView AskGrid;
        private DataGridView BidGrid;
        private SplitContainer SplitContainer1;
        private Label ContractFetchStatusLabel;
        private Label ContractsCountLabel;
        private ProgressBar ContractFetchProgressBar;
        private Panel ConnectionPanel;
        private TextBox ClientIdTextBox;
        private Label Label15;
        private TextBox PortTextBox;
        private Label Label14;
        private TextBox ServerTextBox;
        private Label Label13;
        private Button ConnectDisconnectButton;
        private Label ConnectionStatusLabel;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn MarketMaker;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn AveragePrice;
        private Panel ContractSpecifierPanel;
        private Button StartSnapshotsButton;
        private DataGridViewTextBoxColumn ContractId;
        private DataGridViewTextBoxColumn ContractLocalSymbol;
        private DataGridViewTextBoxColumn ContractSecType;
        private DataGridViewTextBoxColumn ContractSymbol;
        private DataGridViewTextBoxColumn ContractTradingClass;
        private DataGridViewTextBoxColumn ContractExchange;
        private DataGridViewTextBoxColumn ContractPrimaryExchange;
        private DataGridViewTextBoxColumn ContractCurrency;
        private DataGridViewTextBoxColumn ContractExpiry;
        private DataGridViewTextBoxColumn ContractStrike;
        private DataGridViewTextBoxColumn ContractRight;
        private DataGridViewTextBoxColumn ContractMultiplier;
        private DataGridViewTextBoxColumn Symbol;
        private DataGridViewTextBoxColumn BidSize;
        private DataGridViewTextBoxColumn BidPrice;
        private DataGridViewTextBoxColumn LastPrice;
        private DataGridViewTextBoxColumn LastSize;
        private DataGridViewTextBoxColumn AskPrice;
        private DataGridViewTextBoxColumn AskSize;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn HighPrice;
        private DataGridViewTextBoxColumn LowPrice;
        private DataGridViewTextBoxColumn Open;
        private DataGridViewTextBoxColumn ClosePrice;
    }
}

