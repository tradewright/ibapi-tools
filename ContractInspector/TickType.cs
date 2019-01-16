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

public enum TickType {
    BidSize,
    Bid,
    Ask,
    AskSize,
    Last,
    LastSize,
    High,
    Low,
    Volume,
    Close,
    BidOption,
    AskOption,
    LastOption,
    ModelOption,
    Open,
    Low13Week,
    High13Week,
    Low26Week,
    High26Week,
    Low52Week,
    High52Week,
    AvgVolume,
    OpenInterest,
    OptionHistoricalVol,
    OptionImpliedVol,
    OptionBidExch,
    OptionAskExch,
    OptionCallOpenInterest,
    OptionPutOpenInterest,
    OptionCallVolume,
    OptionPutVolume,
    IndexFuturePremium,
    BidExch,
    AskExch,
    AuctionVolume,
    AuctionPrice,
    AuctionImbalance,
    MarkPrice,
    BidEfpComputation,
    AskEfpComputation,
    LastEfpComputation,
    HighEfpComputation,
    LowEfpComputation,
    OpenEfpComputation,
    CloseEfpComputation,
    LastTimestamp,
    Shortable,
    Fundamentals,
    RTVolume,
    Halted,
    BidYield,
    AskYield,
    LastYield,
    CustOptComp,
    Trades,
    TradesPerMin,
    VolumePerMin,
    LastRTHTrade,
    RTHistoricalVol,
    IBDividends,
    BondFactorMultiplier,
    RegulatoryImbalance,
    NewsTick,
    ShortTermVolume3Min,
    ShortTermVolume5Min,
    ShortTermVolume10Min,
    DelayedBid,
    DelayedAsk,
    DelayedLast,
    DelayedBidSize,
    DelayedAskSize,
    DelayedLastSize,
    DelayedHigh,
    DelayedLow,
    DelayedVolume,
    DelayedClose,
    DelayedOpen,
    RTTrdVolume,
    CreditmanMarkPrice,
    CreditmanSlowMarkPrice,
    DelayedBidOption,
    DelayedAskOption,
    DelayedLastOption,
    DelayedModelOption,
    LastExchange,
    LastRegulatoryTime,
    FuturesOpenInterest,
    AverageOptionVolume,
    DelayedLastTimestamp,
    ShortableShares
}

