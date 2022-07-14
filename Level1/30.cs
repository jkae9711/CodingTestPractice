// #30 : 최대공약수와 최소공배수

using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n, int m)
    {
        if (n == m)
            return new int[] { n, n };

        int iGCD, iLCM, iTemp;
        List<int> lstNDivisor = new List<int>();
        List<int> lstMDivisor = new List<int>();

        iTemp = n;

        while(iTemp >= 1)
        {
            if (n % iTemp == 0)
                lstNDivisor.Add(iTemp);

            iTemp--;
        }

        iTemp = m;

        while(iTemp >= 1)
        {
            if (m % iTemp == 0)
                lstMDivisor.Add(iTemp);

            iTemp--;
        }

        iGCD = (from divisor in lstNDivisor.Intersect(lstMDivisor)
                select divisor).Max();

        iLCM = n * m / iGCD;

        return new int[] { iGCD, iLCM };
    }
}