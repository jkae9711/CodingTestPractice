// #41 : 약수의 개수와 덧셈

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int left, int right)
    {
        int iSum = 0;
        List<int> lstInput = Enumerable.Range(left, right - left + 1).ToList();

        for (int iIndex = 0; iIndex < lstInput.Count; iIndex++)
        {
            if (GetDivisorCount(lstInput[iIndex]) % 2 == 0)
                iSum += lstInput[iIndex];
            else
                iSum -= lstInput[iIndex];
        }

        return iSum;
    }

    public int GetDivisorCount(int iInput)
    {
        int iDivisorCount = 0;

        for (int iNumber = 1; iNumber <= iInput; iNumber++)
        {
            if (iInput % iNumber == 0)
                iDivisorCount++;
        }

        return iDivisorCount;
    }
}