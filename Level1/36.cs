// #36 : 음양 더하기

using System;
using System.Linq;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int iSum = 0;

        for (int index = 0; index < absolutes.Length; index++)
        {
            if (signs[index] == true)
                iSum += absolutes[index];
            else
                iSum -= absolutes[index];
        }

        return iSum;
    }
}