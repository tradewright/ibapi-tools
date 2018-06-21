#region License

// The MIT License (MIT)
//
// Copyright (c) 2018 Richard L King (TradeWright Software Systems)
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
using System.Threading;

namespace ContractInspector
{
    /// <summary>
    /// This class receives the callbacks from the API.
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// Each method in this class override the corresponding method from the DefaultEWrapper class provided by IB.
    ///  Since DefaultEWrapper implements EWrapper, an instance of this class can be supplied to the constructor
    ///  for EClientSocket.
    /// 
    ///  Each method calls the corresponding method in Form1, posting via the synchronization context to ensure
    ///  that the processing is carried out on the UI thread.
    /// 
    ///  Note that the method implementations in DefaultEWrapper all do nothing, so there is no need to call the
    ///  base implementations.
    /// 
    /// </remarks>
    public class ApiEventSource : DefaultEWrapper
    {
        private MainForm mUI;
        private SynchronizationContext mSyncContext;

        internal ApiEventSource(MainForm UI, SynchronizationContext syncContext)
        {
            this.mUI = UI;
            this.mSyncContext = syncContext;
        }

        public override void connectAck()
        {
            mSyncContext.Post((t) => mUI.connectAck(), null);
        }

        public override void connectionClosed()
        {
            mSyncContext.Post((t) => mUI.connectionClosed(), null);
        }

        public override void contractDetails(int reqId, ContractDetails contractDetails) {
            mSyncContext.Post((t) => mUI.contractDetails(reqId, contractDetails), null);
        }

        public override void contractDetailsEnd(int reqId) {
            mSyncContext.Post((t) => mUI.contractDetailsEnd(reqId), null);
        }

        public override void currentTime(long time)
        {
            mSyncContext.Post((t) => mUI.currentTime(time), null);
        }

        public override void error(Exception e)
        {
            mSyncContext.Post((t) => mUI.error(e), null);
        }

        public override void error(string str)
        {
            mSyncContext.Post((t) => mUI.error(str), null);
        }

        public override void error(int id, int errorCode, string errorMsg)
        {
            mSyncContext.Post((t) => mUI.error(id, errorCode, errorMsg), null);
        }

        public override void managedAccounts(string accountsList)
        {
            mSyncContext.Post((t) => mUI.managedAccounts(accountsList), null);
        }

        public override void tickGeneric(int tickerId, int field, double value)
        {
            mSyncContext.Post((t) => mUI.tickGeneric(tickerId, field, value), null);
        }

        public override void tickString( int tickerId, int field, string value)
        {
            mSyncContext.Post((t) => mUI.tickString(tickerId, field, value), null);
        }

        public override void tickPrice(int tickerId, int tickType, double price, TickAttrib attribs)
        {
            mSyncContext.Post((t) => mUI.tickPrice(tickerId, tickType, price, attribs), null);
        }

        public override void tickSize(int tickerId, int tickType, int size)
        {
            mSyncContext.Post((t) => mUI.tickSize(tickerId, tickType, size), null);
        }

        public override void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            mSyncContext.Post((t) => mUI.updateMktDepth(tickerId, position, "", operation, side, price, size), null);
        }

        public override void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size)
        {
            mSyncContext.Post((t) => mUI.updateMktDepth(tickerId, position, marketMaker, operation, side, price, size), null);
        }

    }
}
