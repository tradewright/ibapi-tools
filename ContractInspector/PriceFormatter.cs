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

        private static List<TickSizePatternEntry> mPriceFormatStrings = new List<TickSizePatternEntry>();

        private const string ThirtySecondsSeparator = "'";
        private const string ThirtySecondsAndFractionsSeparator = "'";

        private const string SixtyFourthsSeparator = "''";
        private const string SixtyFourthsAndFractionsSeparator = "''";

        private const string ExactThirtySecondIndicator = "0";
        private const string QuarterThirtySecondIndicator = "¼";
        private const string HalfThirtySecondIndicator = "+";
        private const string ThreeQuarterThirtySecondIndicator = "¾";

        private const string ExactSixtyFourthIndicator = "''";
        private const string HalfSixtyFourthIndicator = "+";

        public static string FormatPrice(double pPrice, string pSecType, double pTickSize) {
            // see http://www.cmegroup.com/trading/interest-rates/files/TreasuryFuturesPriceRoundingConventions_Mar_24_Final.pdf
            // for details of price presentation, especially sections (2) and (7)

            if (pTickSize == OneThirtySecond) return FormatPriceAs32nds(pPrice);

            if (pTickSize == OneSixtyFourth) {
                if (pSecType == "FUT")
                    return FormatPriceAs32ndsAndFractions(pPrice);
                return FormatPriceAs64ths(pPrice);
            }

            if (pTickSize == OneHundredTwentyEighth) {
                if (pSecType == "FUT")
                    return FormatPriceAs32ndsAndFractions(pPrice);
                return FormatPriceAs64thsAndFractions(pPrice);
            }

            return FormatPriceAsDecimals(pPrice, pTickSize);
        }

        public static string FormatPriceAs32nds(double pPrice) {
            var priceInt = Math.Floor(pPrice);
            var fract = pPrice - priceInt;
            var numerator = fract * 32;
            return $"{(int)priceInt,0:d}{ThirtySecondsSeparator}{numerator,1:00}";
        }

        public static string FormatPriceAs32ndsAndFractions(double pPrice) {
            var priceInt = Math.Floor(pPrice);
            var fract = pPrice - priceInt;
            var numerator = (int)(Math.Floor(fract * 128));
            int rem;
            Math.DivRem(numerator, 4, out rem);
            var priceString = $"{(int)priceInt,0:d}{ThirtySecondsAndFractionsSeparator}{rem,1:00}";
            switch (rem) {
            case 0:
                priceString = priceString + ExactThirtySecondIndicator;
                break;
            case 1:
                priceString = priceString + QuarterThirtySecondIndicator;
                break;
            case 2:
                priceString = priceString + HalfThirtySecondIndicator;
                break;
            case 3:
                priceString = priceString + ThreeQuarterThirtySecondIndicator;
                break;
            }

            return priceString;
        }

        public static string FormatPriceAs64ths(double pPrice) {
            var priceInt = Math.Floor(pPrice);
            var fract = pPrice - priceInt;
            var numerator = (int)Math.Floor(fract * 64);
            return $"{(int)priceInt,0:d}{SixtyFourthsSeparator}{numerator,1:00}";
        }

        public static string FormatPriceAs64thsAndFractions(double pPrice) {
            var priceInt = Math.Floor(pPrice);
            var fract = pPrice - priceInt;
            var numerator = (int)Math.Floor(fract * 128);
            int rem;
            rem = Math.DivRem(numerator, 2, out rem);
            var priceString = $"{(int)priceInt,0:d}{SixtyFourthsAndFractionsSeparator}{rem,1:00}";
            switch (rem) {
            case 0:
                priceString = priceString + ExactSixtyFourthIndicator;
                break;
            case 1:
                priceString = priceString + HalfSixtyFourthIndicator;
                break;
            }

            return priceString; // + SixtyFourthsAndFractionsTerminator;
        }

        public static string FormatPriceAsDecimals(double pPrice, double pTickSize) {
            return pPrice.ToString(getPriceFormatString(pTickSize));
        }

        private static string generatePriceFormatString(double pTickSize) {
            var lNumberOfDecimals = pTickSize.ToString("0.##############").Length - 2;

            if (lNumberOfDecimals == 0)
                return "0";
            else
                return "0." + new String('0', lNumberOfDecimals);
        }

        private static string getPriceFormatString(double pTickSize) {
            for (var i = 0; i < mPriceFormatStrings.Count; i++) {
                if (mPriceFormatStrings[i].TickSize == pTickSize)
                    return mPriceFormatStrings[i].Pattern;
            }

            var pattern = generatePriceFormatString(pTickSize);
            mPriceFormatStrings.Add(new TickSizePatternEntry() { TickSize = pTickSize, Pattern = pattern });
            return pattern;
        }

    }
}
