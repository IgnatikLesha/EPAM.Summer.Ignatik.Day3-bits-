using System;
using System.Collections.Generic;
using InstertNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace BitsOperationsTest
{
    [TestFixture]
    public class BeetsWorkTests
    {

        [TestCaseSource("Parameters")]
        public string BitsMoveTests(int first, int second, int start, int finish)
        {
            return Convert.ToString(BitsOperations.InsertNumber(first, second, start, finish), 2);
        }
        public IEnumerable<TestCaseData> Parameters()
        {
            yield return new TestCaseData(100, 90, 7, 13).Returns("1011011100100");
            yield return new TestCaseData(100, 90, 32, 30).Throws(typeof(ArgumentException));
            yield return new TestCaseData(100, 90, 2, 13).Returns("101101100");
            yield return new TestCaseData(100, 90, 1, 33).Throws(typeof(ArgumentException));
            yield return new TestCaseData(100, 90, 9, 13).Returns("1011001100100");
            yield return new TestCaseData(100, 90, 14, 3).Throws(typeof(ArgumentException));
            yield return new TestCaseData(100, 90, 18, 30).Returns("1011010000000000001100100");
            yield return new TestCaseData(100, 90, -2, 30).Throws(typeof(ArgumentException));
            yield return new TestCaseData(100, 90, 1, -30).Throws(typeof(ArgumentException));
        }
    }
}
