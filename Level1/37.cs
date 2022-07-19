// #37 : 예산

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        d = (from money in d
            orderby money
            select money)
            .ToArray();

        int iAcceptCount = 0;

        foreach (var money in d)
        {
            if (money <= budget)
            {
                iAcceptCount++;
                budget -= money;
            }
            else
                break;
        }

        return iAcceptCount;
    }
}