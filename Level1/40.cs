// #40 : 3진법 뒤집기

using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public int solution(int n)
    {
        if (n / 3 == 0 || n == 1)
            return 1;
        // n == 1인 경우와 n이 3의 배수인 경우에 아래 로직이 정상작동 하지않아 예외처리

        int iInput = n;
        int iCountDigit = 0;
        List<int> lst10To3 = new List<int>();
        int iAnswer = 0;

        while (true)
        {
            int iPower = (int)Math.Pow(3, iCountDigit);

            if (iInput < iPower)
            {
                iCountDigit--;

                break;
            }
            else
                iCountDigit++;
        }

        for (int iDigit = iCountDigit; iDigit >= 0; iDigit--)
        {
            int iDivisor = (int)Math.Pow(3, iDigit);
            int iQuotient = iInput / iDivisor;

            iInput %= iDivisor;
            lst10To3.Add(iQuotient);
        }

        for (int iCountIndex = 0; iCountIndex < lst10To3.Count; iCountIndex++)
            iAnswer += lst10To3[iCountIndex] * (int)Math.Pow(3, iCountIndex);

        return iAnswer;
    }
}