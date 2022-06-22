// #10 : 두 개 뽑아서 더하기

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        HashSet<int> hsAddResult = new HashSet<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 1; j < numbers.Length - i; j++)
            {
                hsAddResult.Add(numbers[i] + numbers[i + j]);
            }
        }

        answer = hsAddResult.ToArray();
        Array.Sort(answer);

        return answer;
    }
}
