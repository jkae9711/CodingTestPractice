// #9 : 나누어 떨어지는 숫자 배열

using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                answer[i] = arr[i];
            }
        }

        if (answer.Sum() == 0)
        {
            answer[0] = -1;
        }

        answer = answer.Where(x => x != 0).ToArray();
        Array.Sort(answer);

        return answer;
    }
}