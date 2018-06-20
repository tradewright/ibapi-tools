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

        internal void error(int id, int errorCode, string errorMsg) {
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
