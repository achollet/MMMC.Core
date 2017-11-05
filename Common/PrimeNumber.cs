using System;

namespace Common
{
    public class PrimeNumber
    {
        public bool IsPrimeNumber(int number)
        {
            var factor = 1;

            if (number%2==0 && number > 2)
            {
                return false;
            }

            while (factor <= Math.Sqrt(number))
            {
                if (number%factor==0)
                {
                    return false;
                }
                factor++;
            }

            return true;
        }
    }
}
