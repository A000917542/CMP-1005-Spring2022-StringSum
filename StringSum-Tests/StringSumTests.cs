using CMP_1005_Spring2022_StringSum;
using Microsoft.Scripting.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace StringSum_Tests
{
    [TestClass]
    public class StringSumTests
    {
        [TestMethod]
        public void StringSumAddMethodShouldExist()
        {
            MethodInfo info =  typeof(StringSum).GetMethod("Add");
            Assert.IsNotNull(info);
        }

        [TestMethod]
        [DataRow("4", 4)]
        [DataRow("5", 5)]
        public void StringSumAddMethodShouldReturnIntegerWhenGivenSingleString(string input, int expected)
        {
            int result = StringSum.Add(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("4 5", 9)]
        [DataRow("5 6", 11)]
        public void StringSumAddMethodShouldReturnIntegerWhenGiven2NumberString(string input, int expected)
        {
            int result = StringSum.Add(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("4 5 1", 10)]
        [DataRow("5 6 1", 12)]
        public void StringSumAddMethodShouldReturnIntegerWhenGiven3NumberString(string input, int expected)
        {
            int result = StringSum.Add(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("-4 -5 -1", -10)]
        [DataRow("-5 -6 -1", -12)]
        public void StringSumAddMethodShouldReturnIntegerWhenGiven3NegativeNumberString(string input, int expected)
        {
            int result = StringSum.Add(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("-4 -5 1", -8)]
        [DataRow("5 -6 1", 0)]
        public void StringSumAddMethodShouldReturnIntegerWhenGiven3NegativeOrPositiveNumberString(string input, int expected)
        {
            int result = StringSum.Add(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("A -5 1", -8)]
        [DataRow("5 B 1", 0)]
        public void StringSumAddMethodShouldCauseAnInvalidArgumentExceptionWhenGivenANonNumberString(string input, int expected)
        {
            Assert.ThrowsException<ArgumentException>(() => StringSum.Add(input));
            
        }
    }
}
