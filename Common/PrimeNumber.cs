using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class PrimeNumber : IPrimeNumber
    {
        public bool IsPrimeNumber(int number)
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

        public List<int> PrimeNumberList(int listSize)
        {
            var primeNumberList = new List<int>();

            if (listSize > 0) 
                primeNumberList.Add(2);

            var nextNumber = 3;

            while (primeNumberList.Count < listSize)
            {
                if (nextNumber%2!=0)
                {
                    if (!primeNumberList.Any(n => nextNumber%n==0))
                    primeNumberList.Add(nextNumber);
                }
                
                nextNumber++;
            }

            return primeNumberList;
        }

        public List<int> DecompositionInPrimeNumber(int number)
        {
            var listOfPrimeNumber = new List<int>();
            if (number%2== 0)
            {
                listOfPrimeNumber.Add(2);
                number = number/2;
            }

            while(number > 1)
            {
                break;
            }

            return listOfPrimeNumber;
        }
    }
}
