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
        private DataGridView mBidGrid;
        private DataGridView mAskGrid;

        private string mSecType;
        private double mTickSize;

        internal bool InProgress { get; private set; }
        
        internal MarketDepthManager(DataGridView bidGrid, DataGridView askGrid)
        {
            this.mBidGrid = bidGrid;
            this.mAskGrid = askGrid;
        }

        internal void UpdateMktDepth(int tickerId, int rowId, string marketMaker, OperationType operation, Side side, double price, int size)
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

        internal void Initialise(int numberOfRows, string secType, double tickSize)
        {
            mSecType = secType;
            mTickSize = tickSize;
            this.mAsks = new List<ModelEntry>(numberOfRows);
            this.mBids = new List<ModelEntry>(numberOfRows);
            InProgress = true;
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
                                int size)
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
            int cumSize = 0;
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
                row.Cells[(int)Cell.MarketMaker].Value = modelEntry.MarketMaker;
                row.Cells[(int)Cell.Price].Value = PriceFormatter.FormatPrice(modelEntry.Price, mSecType, mTickSize);
                row.Cells[(int)Cell.Size].Value = modelEntry.Size;
                row.Cells[(int)Cell.CumSize].Value = cumSize;
                row.Cells[(int)Cell.AvgPrice].Value = avgPrice;
            }
        }

        private class ModelEntry
        {
            internal string MarketMaker;
            internal double Price;
            internal int Size;
            internal int CumSize;
            internal double TotalPrice;
        }
    }
}
