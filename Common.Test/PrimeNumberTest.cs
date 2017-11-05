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
        [DataRow(5)]
        [DataRow(17)]
        public void ReturnTrueWhenPassingAPrimeNumber(int value)
        {
            var primeNumber = new PrimeNumber();

            Assert.IsTrue(primeNumber.IsPrimeNumber(value));
        }
    }
}
