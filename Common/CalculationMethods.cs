using System;
using System.Collections.Generic;

public class CalculationMethods
{
    public long Factoriel(long l)
    {
        if (l > 0)
        {
            return l*Factoriel(l-1);
        }

        return 1;
    }

    public List<long> PrimeNumberDecomposition(long l)
    {
            return new List<long>();
    }

    private List<long> PrimeNumberList(long l)
    {
        var primeNumberList = new List<long>();
        if (l > 0)
            primeNumberList.Add(1); 

        for (long i = 1; i <= l ; i ++)
        {
            if (i%2!= 0)
            {
                var isPrime = true;
                foreach (var prime in primeNumberList)
                {
                    if (i%prime ==0)
                        isPrime = false;
                }

                if (isPrime)
                    primeNumberList.Add(i);
            }
        }

        return primeNumberList;
    } 

}