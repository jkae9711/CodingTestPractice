// #34 : 소수 찾기

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        List<int> lstPrimeNumber = new List<int>();
        bool bIsBreak = false;

        for (int number = 2; number <= n; number++)
        {
            if (number > 2 && number % 2 == 0)
                continue;

            foreach (var PrimeNumber in lstPrimeNumber)
            {
                if (PrimeNumber > Math.Sqrt(number))
                    break;

                if (number % PrimeNumber == 0)
                {
                    bIsBreak = true;

                    break;
                }
            }

            if (bIsBreak)
            {
                bIsBreak = false;

                continue;
            }

            lstPrimeNumber.Add(number);
        }

        return lstPrimeNumber.Count;
    }
}