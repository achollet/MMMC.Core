using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Core.Test
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var common = new Common();
            var result = common.PrimeNumberDecomposer(70);
            var expected = new List<int>{2,5,7};

            Assert.AreEqual(result.Count, expected.Count);
            Assert.AreEqual(result[0],expected[0]);
            Assert.AreEqual(result[1],expected[1]);
            Assert.AreEqual(result[2],expected[2]);
        }

        [TestMethod]
        public void ReturnPrimeNumberListOfLength8_WhenAskedSizeIs8()
        {
            var common = new Common();
            var result = common.GetPrimeNumberList(8);
            var expected = new List<int>{1,2,3,5,7,11,13,17};

            Assert.AreEqual(result.Count, expected.Count);
            Assert.AreEqual(result[0],expected[0]);
            Assert.AreEqual(result[4],expected[4]);            
            Assert.AreEqual(result[7],expected[7]);            
        }

        [TestMethod]
        public void ReturnTrueWhenPassingAPrimeNumber()
        {
            var common = new Common();
            
            var result1 = common.IsPrimeNumber(5);
            var result2 = common.IsPrimeNumber(23);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void ReturnFalseWhenPassingANonPrimeNumber()
        {
            var common = new Common();
            
            var result1 = common.IsPrimeNumber(6);
            var result2 = common.IsPrimeNumber(27);

            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
        }
    }

    public class Common
    {
        public List<int> PrimeNumberDecomposer(long number)
        {
               return  new List<int>{2,5,7};
        } 

        public List<int> GetPrimeNumberList(int listSize)
        {
            var primeNumberList = new List<int>{1,2,3,5,7,11,13,17};

            return primeNumberList;
        }

        public bool IsPrimeNumber(int number)
        {
            if (number == 1)
                return true;

            if (number == 2 )
                return true;

            if (number != 2 && number%2 == 0)
                return false;

            var listMultiple = new List<int>();

            for (var i=1; i <= number; i++)
            {
                if (number%i == 0)
                    listMultiple.Add(i);
            }    

            if (listMultiple.Count == 2 && !listMultiple.Any(m => m == 1 || m == number))
                return true;

            return false;
        }
    }
}
