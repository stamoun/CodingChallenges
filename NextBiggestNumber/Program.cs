//*****************************************************************************
// Project: NextBiggestNumber
// Created Date: Saturday January 26th 2019
// Copyright (c) 2019 Nicolas St-Amour
//*****************************************************************************

using System;

namespace Stamoun.CodingChallenges.NextBiggestNumber
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Please enter a number: ");
            var userInput = Console.ReadLine();

            var nextBiggestNumber = NextBiggestNumber.GetNext(userInput);
            Console.WriteLine("Next biggest number is: " + nextBiggestNumber);
        }
    }
}
