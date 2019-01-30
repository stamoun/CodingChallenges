//*****************************************************************************
// Project: NextBiggestNumberTests
// Created Date: Saturday January 26th 2019
// Copyright (c) 2019 Nicolas St-Amour
//*****************************************************************************

using NUnit.Framework;
using System;

namespace Stamoun.CodingChallenges.NextBiggestNumber.Tests
{
    public class GetNext
    {
        [Test]
        [TestCase("")]
        [TestCase("foo")]
        public void ShouldThrowInvalidArgumentException(string testInput)
            => Assert.Throws<ArgumentException>(() => NextBiggestNumber.GetNext(testInput));

        [Test]
        [TestCase("2", "-1")]
        [TestCase("12", "21")]
        [TestCase("122", "212")]
        [TestCase("441", "-1")]
        [TestCase("2017", "2071")]
        [TestCase("2071", "2107")]
        [TestCase("1234", "1243")]
        [TestCase("4321", "-1")]
        [TestCase("63842", "64238")]
        [TestCase("218765", "251678")]
        [TestCase("534976", "536479")]
        public void ShouldReturnValidValue(string testInput, string expectedOutput)
            => Assert.AreEqual(expectedOutput, NextBiggestNumber.GetNext(testInput));
    }
}