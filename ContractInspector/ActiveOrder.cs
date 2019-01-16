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
