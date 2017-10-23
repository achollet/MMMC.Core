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
        return new List<long>();
    } 

}