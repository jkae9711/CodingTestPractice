// #17 : 자릿수 더하기

using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string strNumber = n.ToString();

        foreach (char item in strNumber)
        {
            answer += Convert.ToInt32(item.ToString());
        }

        return answer;
    }
}