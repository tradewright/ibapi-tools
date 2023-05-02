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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContractInspector
{
    public class MarketDepthManager
    {
        internal enum OperationType
        {
            Insert,
            Update,
            Delete,
        }

        internal enum Side
        {
            Ask,
            Bid,
        }

        internal enum Cell
        {
            MarketMaker,
            Price,
            Size,
            CumSize,
            AvgPrice,
        }

        private List<ModelEntry> mAsks;
        private List<ModelEntry> mBids;
        private readonly DataGridView mBidGrid;
        private readonly DataGridView mAskGrid;

        private PriceFormatter.PriceFormatFunction mFormatPrice;
        private PriceFormatter.PriceFormatFunction mFormatAvgPrice;

        internal bool InProgress { get; private set; }
        
        internal MarketDepthManager(DataGridView bidGrid, DataGridView askGrid)
        {
            this.mBidGrid = bidGrid;
            this.mAskGrid = askGrid;
        }

        internal void UpdateMktDepth(int tickerId, int rowId, string marketMaker, OperationType operation, Side side, double price, decimal size)
        {
            switch (side)
            {
            case Side.Ask:
                this.updateDepth(this.mAsks, this.mAskGrid, rowId, marketMaker, operation, side, price, size);
                break;
            case Side.Bid:
                this.updateDepth(this.mBids, this.mBidGrid, rowId, marketMaker, operation, side, price, size);
                break;
            default:
                throw new InvalidOperationException();
            }
        }

        internal void Initialise(int numberOfRows, string secType, double tickSize) {
            this.mAsks = new List<ModelEntry>(numberOfRows);
            this.mBids = new List<ModelEntry>(numberOfRows);
            InProgress = true;

            mFormatPrice = PriceFormatter.GetPriceFormatter(secType, tickSize);
            mFormatAvgPrice = PriceFormatter.GetPriceFormatter(secType, tickSize, true);

        }

        internal void Clear()
        {
            this.mAskGrid?.Rows.Clear();
            this.mBidGrid?.Rows.Clear();
            InProgress = false;
        }

        private void updateDepth(List<ModelEntry> model, 
                                DataGridView bookEntries, 
                                int rowId, 
                                string marketMaker, 
                                OperationType operation, 
                                Side side, 
                                double price, 
                                decimal size)
        {
            switch (operation)
            {
            case OperationType.Insert:
                model.Insert(rowId, new ModelEntry() { MarketMaker = marketMaker, Price = price, Size = size });
                break;
            case OperationType.Update:
                model[rowId].MarketMaker = marketMaker;
                model[rowId].Price = price;
                model[rowId].Size = size;
                break;
            case OperationType.Delete:
                if (rowId < model.Count)
                    model.RemoveAt(rowId);
                break;
            }
            this.updateList(model, bookEntries, rowId);
        }

        private void updateList(List<ModelEntry> model, DataGridView bookEntries, int baseRow)
        {
            double totalSize = 0.0;
            decimal cumSize = 0;
            if (baseRow > 0)
            {
                var modelEntry = model[checked(baseRow - 1)];
                cumSize = model[checked(baseRow - 1)].CumSize;
                totalSize = model[checked(baseRow - 1)].TotalPrice;
            }

            for (var i = baseRow; i < model.Count; i++) { 
                ModelEntry modelEntry = model[i];
                checked { cumSize += modelEntry.Size; }
                modelEntry.CumSize = cumSize;
                totalSize += modelEntry.Price * (double)modelEntry.Size;
                modelEntry.TotalPrice = totalSize;

                double avgPrice = totalSize / (double)cumSize;

                if (i > checked(bookEntries.Rows.Count - 1))
                    bookEntries.Rows.Add();
                var row = bookEntries.Rows[i];
                bookEntries.Rows[i].SetValues(modelEntry.MarketMaker,
                                            mFormatPrice(modelEntry.Price),
                                            modelEntry.Size,
                                            cumSize,
                                            mFormatAvgPrice(avgPrice));
            }
        }

        private class ModelEntry
        {
            internal string MarketMaker;
            internal double Price;
            internal decimal Size;
            internal decimal CumSize;
            internal double TotalPrice;
        }
    }
}
