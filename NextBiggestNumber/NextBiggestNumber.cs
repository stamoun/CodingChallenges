//*****************************************************************************
// Project: NextBiggestNumber
// Created Date: Saturday January 26th 2019
// Copyright (c) 2019 Nicolas St-Amour
//*****************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace Stamoun.CodingChallenges.NextBiggestNumber
{
    public static class NextBiggestNumber
    {
        public static string GetNext(string inputString)
        {
            if (!int.TryParse(inputString, out _))
            {
                throw new ArgumentException(
                    "Invalid input string \"{0}\", not a number",
                    inputString);
            }

            if (inputString.Length == 1)
            {
                return "-1";
            }

            var digits = inputString.ToCharArray().ToList();

            digits = TraverseDigits(digits, digits.Count - 1);

            var result = new string(digits.ToArray());

            return result.Equals(inputString)
                ? "-1"
                : result;
        }

        private static List<char> TraverseDigits(List<char> digits, int currentIndex)
        {
            if (currentIndex < 0)
            {
                // no possible solution
                return digits;
            }

            var currentValue = digits[currentIndex];

            for (var i = currentIndex - 1; i >= 0; --i)
            {
                var nextValue = digits[i];

                if (currentValue <= nextValue)
                {
                    continue;
                }

                digits.Insert(i, currentValue);
                digits.RemoveAt(currentIndex + 1);
                currentIndex = i;

                // orderAsc the lower numbers once a swap is done
                var subList = digits.GetRange(currentIndex + 1, digits.Count - currentIndex - 1);
                subList = subList.OrderBy(c => c).ToList();
                digits.RemoveRange(currentIndex + 1, subList.Count);

                return digits.Concat(subList).ToList();
            }

            return TraverseDigits(digits, currentIndex - 1);
        }
    }
}