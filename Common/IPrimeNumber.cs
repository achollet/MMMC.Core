using System;
using System.Collections.Generic;

namespace Common
{
    public interface IPrimeNumber
    {
        bool IsPrimeNumber(int number);
        List<int> PrimeNumberList(int listSize);
    }
}