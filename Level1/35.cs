// #35 : 내적

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] a, int[] b)
    {
        List<int> lstDotProduct = new List<int>();

        for (int index = 0; index < a.Length; index++)
        {
            lstDotProduct.Add(a[index] + b[index]);
        }

        return lstDotProduct.Sum();
    }
}