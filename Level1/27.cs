// #27 : 정수 제곱근 판별

using System;

public class Solution
{
    public long solution(long n)
    {
        long lsqrt = 0;

        if (long.TryParse(Math.Sqrt(n).ToString(), out lsqrt) == true) return lsqrt + 1;
        else return -1;
    }
}