using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Test
{
    [TestClass]
    public class CommonCalculationTest_IsShould
    {
        private readonly CalculationMethods _calculationMethods;

        public CommonCalculationTest_IsShould()
        {
            _calculationMethods = new CalculationMethods();
        }

        [TestMethod]
        public void Return24GivenTheValueOf4()
        {
            long expected = 24;
            var result = _calculationMethods.Factoriel(4);

            Assert.AreEqual(result,expected);
        } 

        [TestMethod]
        public void Return6GivenTheValueOf3()
        {
            long expected = 6;
            var result = _calculationMethods.Factoriel(3);

            Assert.AreEqual(result,expected);
        } 

        [TestMethod]
        public void ReturnGivenTheValueOf30()
        {
            var expected = new List<long>(){1,2,3,5};
            var result = _calculationMethods.PrimeNumberDecomposition(30);

            Assert.AreEqual(result,expected);
        }
    }
}