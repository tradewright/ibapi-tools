using IBApi;
using System.Windows.Forms;

namespace ContractInspector
{
    /// <summary>
    /// This class contains information relating to a single market data stream.
    /// 
    /// </summary>
    internal class Ticker
    {
        /// <summary>
        /// The contract details For this ticker
        /// 
        /// </summary>
        internal ContractDetails ContractDetails { get; set; }

        /// <summary>
        /// The row in the ticker grid that shows the data for this ticker
        /// 
        /// </summary>
        /// 
        /// <returns/>
        internal DataGridViewRow GridRow { get; set; }

        private Ticker() { }

        internal Ticker(ContractDetails contractDetails) {
            ContractDetails = contractDetails;
        }
    }
}
