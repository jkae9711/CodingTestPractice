// #25 : 하샤드 수

using System;

public class Solution
{
    public bool solution(int x)
    {
        int iSum = 0;

        foreach (var number in x.ToString())
        {
            iSum += Convert.ToInt32(number.ToString());
        }

        if (x % iSum == 0)      return true;
        else                    return false;
    }
}