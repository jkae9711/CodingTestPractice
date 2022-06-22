// #16 : 약수의 합

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n)
    {
        int iTemp;
        List<int> lstDivisor = new List<int>();

        for (int i = 0; i <= n; i++)
        {
            if (int.TryParse(((double)n / (double)i).ToString(), out iTemp))
            {
                lstDivisor.Add(iTemp);
            }
        }

        int answer = lstDivisor.ToArray().Sum();

        return answer;
    }
}