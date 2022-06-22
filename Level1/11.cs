// #11 : 두 정수 사이의 합

public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;
        int iMin, iMax;

        if (a == b)
        {
            answer = a;

            return a;
        }
        else
        {
            iMin = a < b ? a : b;
            iMax = a > b ? a : b;

            for (int i = iMin; i <= iMax; i++)
            {
                answer += i;
            }

            return answer;
        }
    }
}