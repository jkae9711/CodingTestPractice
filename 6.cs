// #6 : 체육복

using System;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        int[] arrCountClothes = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrCountClothes[i] = 1;
        }

        for (int i = 0; i < lost.Length; i++)
        {
            arrCountClothes[lost[i] - 1]--;
        }

        for (int i = 0; i < reserve.Length; i++)
        {
            arrCountClothes[reserve[i] - 1]++;
        }

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                if (arrCountClothes[i] == 0 && arrCountClothes[i + 1] == 2)
                {
                    arrCountClothes[i]++;
                    arrCountClothes[i + 1]--;
                }
            }
            else if (i == (n - 1))
            {
                if (arrCountClothes[i] == 0 && arrCountClothes[i - 1] == 2)
                {
                    arrCountClothes[i]++;
                    arrCountClothes[i - 1]--;
                }
            }
            else // 1 ~ (n - 2)
            {
                if (arrCountClothes[i] == 0 && arrCountClothes[i - 1] == 2)
                {
                    arrCountClothes[i]++;
                    arrCountClothes[i - 1]--;
                }

                if (arrCountClothes[i] == 0 && arrCountClothes[i + 1] == 2)
                {
                    arrCountClothes[i]++;
                    arrCountClothes[i + 1]--;
                }
            }
        }

        foreach (int item in arrCountClothes)
        {
            if (item >= 1)
            {
                answer++;
            }
        }

        return answer;
    }
}