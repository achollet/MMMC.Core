using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Common;

namespace Common.Test
{
    [TestClass]
    public class MathHelperTest
    {
        private readonly MathHelper _mathHelper;

        public MathHelperTest()
        {
            _mathHelper = new MathHelper();
        }

        [DataTestMethod]
        [DataRow(3,6)]
        [DataRow(4,24)]
        [DataRow(6,720)]
        [DataRow(8,40320)]
        [DataRow(11,39916800)]
        public void ReturnFactoriel(int value1, int value2)
        {
            Assert.AreEqual(value2, _mathHelper.Factoriel(value1));
        }
    }
}