// #29 : 자연수 뒤집어 배열로 만들기

using System;
using System.Linq;

public class Solution
{
    public int[] solution(long n)
    {
        var answer = from item in n.ToString()
                     select Convert.ToInt32(item.ToString());

        return answer.Reverse().ToArray();
    }
}