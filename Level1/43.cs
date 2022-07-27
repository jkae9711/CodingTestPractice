// #43 : 최소직사각형

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[,] sizes)
    {
        List<int> lstMax = new List<int>();
        List<int> lstMin = new List<int>();

        for (int iIndex = 0; iIndex < sizes.Length; iIndex++)
        {
            if (sizes[iIndex, 0] >= sizes[iIndex, 1])
            {
                lstMax.Add(sizes[iIndex, 0]);
                lstMin.Add(sizes[iIndex, 1]);
            }
            else
            {
                lstMax.Add(sizes[iIndex, 1]);
                lstMin.Add(sizes[iIndex, 0]);
            }
        }

        return lstMax.Max() * lstMin.Max();
    }
}