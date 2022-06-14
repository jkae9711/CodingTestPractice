// #1 : 로또의 최고 순위와 최저 순위

using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int iCountZero = 0;
        int iCountMatch = 0;

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                iCountZero++;
            }

            for (int j = 0; j < win_nums.Length; j++)
            {
                if (lottos[i] == win_nums[j])
                {
                    iCountMatch++;
                }
            }
        }

        int[] answer = new int[2] {GetRank(iCountMatch + iCountZero),
                                  GetRank(iCountMatch)};

        return answer; // 답
    }

    public static int GetRank(int MatchCount)
    {
        switch (MatchCount)
        {
            case 0:
                return 6;

            case 1:
                return 6;

            case 2:
                return 5;

            case 3:
                return 4;

            case 4:
                return 3;

            case 5:
                return 2;

            case 6:
                return 1;

            default:
                return 0;
        }
    }
}

