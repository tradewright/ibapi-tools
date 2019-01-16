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

using System;
using System.Collections.Generic;

namespace ContractInspector
{
#pragma warning disable RECS0018 // Comparison of floating point numbers with equality operator

    public static class PriceFormatter {

        struct TickSizePatternEntry {
            internal double TickSize;
            internal string Pattern;
        }

        public const double OneTenth = 0.01;
        public const double OneHalf = 0.5;
        public const double OneQuarter = 0.25;
        public const double OneEigth = 0.125;
        public const double OneSixteenth = 0.0625;
        public const double OneThirtySecond = 0.03125;
        public const double OneSixtyFourth = 0.015625;
        public const double OneHundredTwentyEighth = 0.0078125;

        public delegate string PriceFormatFunction(double arg);

        private static List<TickSizePatternEntry> mPriceFormatStrings = new List<TickSizePatternEntry>();

        private const string ThirtySecondsSeparator = "'";
        private const string ThirtySecondsAndFractionsSeparator = "'";

        private const string SixtyFourthsSeparator = "''";
        private const string SixtyFourthsAndFractionsSeparator = "''";

        private const string ExactThirtySecondIndicator = "";
        private const string QuarterThirtySecondIndicator = "¼";
        private const string HalfThirtySecondIndicator = "+";
        private const string ThreeQuarterThirtySecondIndicator = "¾";

        private const string ExactSixtyFourthIndicator = "";
        private const string HalfSixtyFourthIndicator = "+";

        public static PriceFormatFunction GetPriceFormatter(string secType, double tickSize, bool showTickFractionsAsDecimals=false) {
            if (tickSize == OneThirtySecond) {
                if (showTickFractionsAsDecimals)
                    return FormatPriceAs32ndsAndDecimals;
                else
                    return FormatPriceAs32nds;
            }
            if (tickSize == OneSixtyFourth) {
                if (secType == "FUT") {
                    if (showTickFractionsAsDecimals)
                        return FormatPriceAs32ndsAndDecimals;
                    else
                        return FormatPriceAs32ndsAndFractions;
                }
                if (showTickFractionsAsDecimals)
                    return FormatPriceAs64thsAndDecimals;
                else
                    return FormatPriceAs64ths;
            }

            if (tickSize == OneHundredTwentyEighth) {
                if (secType == "FUT") {
                    if (showTickFractionsAsDecimals)
                        return FormatPriceAs64thsAndDecimals;
                    else
                        return FormatPriceAs64thsAndFractions;
                }
                if (showTickFractionsAsDecimals) {
                    return FormatPriceAs64thsAndDecimals;
                } else {
                    return FormatPriceAs64thsAndFractions;
                }
            }

            var formatString = getPriceFormatString(tickSize);
            return (v) => String.Format(formatString, v);
        }

        public static string FormatPrice(double price, string secType, double tickSize, bool showTickFractions) {
            if (tickSize == OneThirtySecond) {
                if (showTickFractions)
                    return FormatPriceAs32ndsAndDecimals(price);
                else
                    return FormatPriceAs32nds(price);
            }

            if (tickSize == OneSixtyFourth) {
                if (secType == "FUT")
                    return FormatPriceAs32ndsAndFractions(price);
                return FormatPriceAs64ths(price);
            }

            if (tickSize == OneHundredTwentyEighth) {
                if (secType == "FUT")
                    return FormatPriceAs64thsAndFractions(price);
                return FormatPriceAs64thsAndFractions(price);
            }

            return FormatPriceAsDecimals(price, tickSize);
        }

        public static string FormatPriceAs32nds(double price) {
            var priceInt = Math.Floor(price);
            var fract = price - priceInt;
            var numberOf32nds = (int)Math.Floor((price - priceInt) * 32);
            return $"{(int)priceInt:d}{ThirtySecondsSeparator}{numberOf32nds:00}";
        }

        public static string FormatPriceAs32ndsAndDecimals(double price) {
            return formatPriceAsNthsAndDecimals(price, 32, ThirtySecondsSeparator);
        }

        public static string FormatPriceAs32ndsAndFractions(double price) {
            var priceInt = Math.Floor(price);
            var numberOf128ths = (int)(Math.Floor((price - priceInt) * 128));
            int rem;
            var numberOf32nds = Math.DivRem(numberOf128ths, 4, out rem);
            var remString = "";
            switch (rem) {
            case 0:
                remString = ExactThirtySecondIndicator;
                break;
            case 1:
                remString = QuarterThirtySecondIndicator;
                break;
            case 2:
                remString = HalfThirtySecondIndicator;
                break;
            case 3:
                remString = ThreeQuarterThirtySecondIndicator;
                break;
            }

            return $"{(int)priceInt:d}{ThirtySecondsAndFractionsSeparator}{(int)numberOf32nds:00}{remString}";
        }

        public static string FormatPriceAs64ths(double price) {
            var priceInt = Math.Floor(price);
            var numberOf64ths = (int)Math.Floor((price - priceInt) * 64);
            return $"{(int)priceInt:d}{SixtyFourthsSeparator}{numberOf64ths:00}";
        }

        public static string FormatPriceAs64thsAndDecimals(double price) {
            return formatPriceAsNthsAndDecimals(price, 64, SixtyFourthsSeparator);
        }

        public static string FormatPriceAs64thsAndFractions(double price) {
            var priceInt = Math.Floor(price);
            var numberOf128ths = (int)(Math.Floor((price - priceInt) * 128));
            int rem;
            var numberOf64ths = Math.DivRem(numberOf128ths, 2, out rem);
            var remString = "";
            switch (rem) {
            case 0:
                remString = ExactSixtyFourthIndicator;
                break;
            case 1:
                remString = HalfSixtyFourthIndicator;
                break;
            }

            return $"{(int)priceInt:d}{SixtyFourthsAndFractionsSeparator}{(int)numberOf64ths:00}{remString}";
        }

        public static string FormatPriceAsDecimals(double price, double tickSize) {
            return price.ToString(getPriceFormatString(tickSize));
        }

        private static string formatPriceAsNthsAndDecimals(double price, int N, string separator) {
            var priceInt = Math.Floor(price);
            var fract = price - priceInt;
            var numberOfNths = Math.Floor(fract * N);
            var f = (int)Math.Round(100.0 * N * (fract - numberOfNths / N));
            if (f == 100) {
                numberOfNths += 1;
                f = 0;
            }
            return $"{(int)priceInt:d}{separator}{numberOfNths:00}.{f:00}";
        }

        private static string generatePriceFormatString(double tickSize) {
            var lNumberOfDecimals = tickSize.ToString("0.##############").Length - 2;

            if (lNumberOfDecimals == 0)
                return "0";
            else
                return "{0:0." + new String('0', lNumberOfDecimals) + "}";
        }

        private static string getPriceFormatString(double tickSize) {
            for (var i = 0; i < mPriceFormatStrings.Count; i++) {
                if (mPriceFormatStrings[i].TickSize == tickSize)
                    return mPriceFormatStrings[i].Pattern;
            }

            var pattern = generatePriceFormatString(tickSize);
            mPriceFormatStrings.Add(new TickSizePatternEntry() { TickSize = tickSize, Pattern = pattern });
            return pattern;
        }

    }
}
