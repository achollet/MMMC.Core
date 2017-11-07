using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace Common.Test
{
    [TestClass]
    public class PrimeNumberTest
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(23)]
        public void IsPrimeNumber(int value)
        {
            Assert.IsTrue(PrimeNumber.IsPrimeNumber(value));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(9)]
        [DataRow(12)]
        public void IsNotPrimeNumber(int value)
        {
            Assert.IsFalse(PrimeNumber.IsPrimeNumber(value));
        }
    }
}
