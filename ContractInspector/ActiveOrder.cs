using IBApi;
using System.Windows.Forms;

namespace ContractInspector
{
    /// <summary>
    /// This class contains information about an order that has been placed with TWS.
    /// 
    /// </summary>
    internal class ActiveOrder
    {
        /// <summary>
        /// The row in the OrdersGrid that shows the details for this order.
        /// 
        /// </summary>
        /// 
        /// <returns/>
        internal DataGridViewRow GridRow { get; set; }

        /// <summary>
        /// The original Order object that was used to place the order. We keep
        ///  this to make it easy to modify the order later
        /// 
        /// </summary>
        /// 
        /// <returns/>
        internal Order Order { get; set; }

        /// <summary>
        /// The contract for this order
        /// 
        /// </summary>
        /// 
        /// <returns/>
        internal Contract Contract { get; set; }

        /// <summary>
        /// The order's current status
        /// 
        /// </summary>
        /// 
        /// <returns/>
        internal string Status { get; set; }
    }
}
