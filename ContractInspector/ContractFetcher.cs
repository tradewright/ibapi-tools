#region License

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
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractInspector
{
    sealed class ContractFetcher
    {
        internal event EventHandler<ContractFetchProgressEventArgs> ContractFetchProgress;

        Stopwatch mStopWatch = new Stopwatch();

        static int mNextRequestID;
        private int mRequestID;

        ContractFetchProgressEventArgs mEventArgs = new ContractFetchProgressEventArgs();

        TaskCompletionSource<List<ContractDetails>> tcs = new TaskCompletionSource<List<ContractDetails>>();
        List<ContractDetails> contractDetailsList = new List<ContractDetails>();

        internal async Task<List<ContractDetails>> FetchContractsAsync(EClientSocket api, Contract contract) {
            mEventArgs.Status = "Fetching contracts";
            OnContractFetchProgress(mEventArgs);

            mStopWatch.Start();
            mRequestID = mNextRequestID++;
            api.reqContractDetails(mRequestID, contract);

            return await tcs.Task;
        }

        internal void AddContractDetails(ContractDetails contractDetails) {
            contractDetailsList.Add(contractDetails);
            mEventArgs.NumberOfContracts += 1;
            if (mStopWatch.ElapsedMilliseconds < 100)
                return;
            mEventArgs.PercentComplete = mEventArgs.PercentComplete + (100f - mEventArgs.PercentComplete) / 100f;
            OnContractFetchProgress(mEventArgs);
        }

        internal void EndContractDetails() {
            mEventArgs.Status = "Sorting contracts";
            mEventArgs.PercentComplete = 100f;
            OnContractFetchProgress(mEventArgs);

            contractDetailsList.Sort(new ContractDetailsComparer());

            mEventArgs.Status = "Loading contracts";
            mEventArgs.PercentComplete = 100f;
            OnContractFetchProgress(mEventArgs);

            tcs.SetResult(contractDetailsList);
        }

        internal void error(int id) {
            if (id == mRequestID) {
                mEventArgs.Status = "Error";
                mEventArgs.PercentComplete = 100f;
                OnContractFetchProgress(mEventArgs);

                tcs.SetResult(contractDetailsList);
            }
        }

        internal void OnContractFetchProgress(ContractFetchProgressEventArgs e) {
            ContractFetchProgress?.Invoke(this, e);
        }
    }

    class ContractFetchProgressEventArgs : System.EventArgs
    {
        internal int NumberOfContracts { get; set; }
        internal float PercentComplete { get; set; }
        internal string Status { get; set; }
    }

}
