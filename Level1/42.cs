// #42 : 나머지가 1이 되는 수 찾기

public class Solution
{
    public int solution(int n)
    {
        int iInput = n - 1;
        int iAnswer = 0;

        for (int i = 2; i <= iInput; i++)
        {
            if (iInput % i == 0)
            {
                iAnswer = i;

                break;
            }
        }

        return iAnswer;
    }
}