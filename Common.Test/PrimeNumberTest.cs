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

        [TestMethod]
        public void ReturnListOf3PrimeNumber()
        {
            var numberToDecompose = 42;
            var expected = new int[]{2, 3, 7}; 

            var result = _primeNumber.DecompositionInPrimeNumber(numberToDecompose);

            Assert.AreEqual(expected.Count(), result.Count);
            Assert.IsTrue(result.Where(n => n.Equals(expected[0])).Any());
            Assert.IsTrue(result.Where(n => n.Equals(expected[0])).Count() == 1);
            Assert.IsTrue(result.Where(n => n.Equals(expected[1])).Any());
            Assert.IsTrue(result.Where(n => n.Equals(expected[1])).Count() == 1);
            Assert.IsTrue(result.Where(n => n.Equals(expected[2])).Any());
            Assert.IsTrue(result.Where(n => n.Equals(expected[2])).Count() == 1);
        }

        [TestMethod]
        public void ReturnListOf4PrimeNumber()
        {
            var numberToDecompose =1155;
            var expected = new int[]{3, 5, 7, 11}; 

            var result = _primeNumber.DecompositionInPrimeNumber(numberToDecompose);

            Assert.AreEqual(expected.Count(), result.Count);
            Assert.IsTrue(result.Where(n => n.Equals(expected[0])).Any());
            Assert.IsTrue(result.Where(n => n.Equals(expected[0])).Count() == 1);
            Assert.IsTrue(result.Where(n => n.Equals(expected[1])).Any());
            Assert.IsTrue(result.Where(n => n.Equals(expected[1])).Count() == 1);
            Assert.IsTrue(result.Where(n => n.Equals(expected[2])).Any());
            Assert.IsTrue(result.Where(n => n.Equals(expected[2])).Count() == 1);
        }
    }
}
