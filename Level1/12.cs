// #12 : 수박수박수박수박수박수?

using System.Text;

public class Solution
{
    public string solution(int n)
    {
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) // 짝수
            {
                answer.Append("수");
            }
            else // i % 2 == 1, 홀수
            {
                answer.Append("박");
            }
        }

        return answer.ToString();
    }
}