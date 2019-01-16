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

using System;
using IBApi;

using System.Collections.Generic;

namespace ContractInspector
{
    class ContractDetailsComparer : IComparer<ContractDetails>
    {
        internal enum ContractSortKeyId
        {
            None,
            LocalSymbol,
            Symbol,
            TradingClass,
            SecType,
            Exchange,
            Expiry,
            Multiplier,
            Currency,
            Right,
            Strike
        }

        internal static ContractSortKeyId[] SortKeys = {
            ContractSortKeyId.SecType,
            ContractSortKeyId.Symbol,
            ContractSortKeyId.TradingClass,
            ContractSortKeyId.Exchange,
            ContractSortKeyId.Currency,
            ContractSortKeyId.Expiry,
            ContractSortKeyId.Multiplier,
            ContractSortKeyId.Strike,
            ContractSortKeyId.Right
        };

        public int Compare(ContractDetails details1, ContractDetails details2) {
            int result = 0;
            for (int i = 0; i < SortKeys.Length; i++) {
                Contract contract1 = details1.Contract;
                Contract contract2 = details2.Contract;

                switch (SortKeys[i]) {
                case ContractSortKeyId.None:
                    result = 0;
                    break;
                case ContractSortKeyId.LocalSymbol:
                    result = string.Compare(contract1.LocalSymbol, contract2.LocalSymbol, true);
                    break;
                case ContractSortKeyId.Symbol:
                    result = string.Compare(contract1.Symbol, contract2.Symbol, true);
                    break;
                case ContractSortKeyId.SecType:
                    result = string.Compare(contract1.SecType, contract2.SecType, true);
                    break;
                case ContractSortKeyId.Exchange:
                    result = string.Compare(contract1.Exchange, contract2.Exchange, true);
                    break;
                case ContractSortKeyId.Expiry:
                    result = string.Compare(contract1.LastTradeDateOrContractMonth, contract2.LastTradeDateOrContractMonth, true);
                    break;
                case ContractSortKeyId.Multiplier:
                    int multiplier1 = string.IsNullOrEmpty(contract1.Multiplier) ? 0 : int.Parse(contract1.Multiplier);
                    int multiplier2 = string.IsNullOrEmpty(contract2.Multiplier) ? 0 : int.Parse(contract2.Multiplier);
                    result = Math.Sign(multiplier1 - multiplier2);
                    break;
                case ContractSortKeyId.Currency:
                    result = string.Compare(contract1.Currency, contract2.Currency, true);
                    break;
                case ContractSortKeyId.Right:
                    result = string.Compare(contract1.Right, contract2.Right, true);
                    break;
                case ContractSortKeyId.Strike:
                    result = Math.Sign(contract1.Strike - contract2.Strike);
                    break;
                case ContractSortKeyId.TradingClass:
                    result = string.Compare(contract1.TradingClass, contract2.TradingClass);
                    break;
                default:
                    throw new InvalidOperationException("Invalid sort key");
                }
                if (result != 0)
                    return result;
            }
            return result;
        }
    }
}
