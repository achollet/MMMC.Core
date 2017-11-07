using System;
using System.Collections.Generic;

namespace Common
{
    public class PrimeNumber
    {
        public static bool IsPrimeNumber(int number)
        {
            var primeFactor = 2;

            if (number <= 1)
                return false;

            if (number > 2 && number % 2 == 0)
                return false;

            while (primeFactor <= Math.Sqrt(number))
            {
                if (number % primeFactor == 0)
                    return false;

                primeFactor++;
            }

            return true;
        }

        public static List<int> PrimeNumberList(int n)
        {
            var primeNumberList = new List<int>();

            if (n > 0) 
                primeNumberList.Add(2);

            return primeNumberList;
        }
    }
}
