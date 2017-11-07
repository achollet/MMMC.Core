using System;

namespace Common
{
    public class PrimeNumber
    {
        public static bool IsPrimeNumber(int number)
        {
            var primeFactor = 1;

            if (number <= 0)
                return false;

            if (number > 2 && number % 2 == 0)
                return false;

            while (primeFactor <= Math.Sqrt(number))
            {
                if (number % primeFactor == 0 && primeFactor!=1)
                    return false;

                primeFactor++;
            }

            return true;
        }
    }
}
