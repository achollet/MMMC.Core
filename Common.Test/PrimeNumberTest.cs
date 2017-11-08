using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Common.Test
{
    [TestClass]
    public class PrimeNumberTest
    {
        private readonly PrimeNumber _primeNumber;

        public PrimeNumberTest()
        {
            _primeNumber = new PrimeNumber();
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(23)]
        [DataRow(29)]
        public void IsPrimeNumber(int value)
        {
            Assert.IsTrue(_primeNumber.IsPrimeNumber(value));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(1)]
        [DataRow(0)]
        [DataRow(9)]
        [DataRow(12)]
        public void IsNotPrimeNumber(int value)
        {
            Assert.IsFalse(_primeNumber.IsPrimeNumber(value));
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(19)]
        public void ReturnPrimeNumberList(int value)
        {
            var result = _primeNumber.PrimeNumberList(value);
            Assert.AreEqual(value, result.Count);
            Assert.IsTrue(result.All(n => _primeNumber.IsPrimeNumber(n)));
        }
    }
}
