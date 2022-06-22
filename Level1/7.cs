// #7 : 가운데 글자 가져오기

public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        if (s.Length % 2 == 1) // 홀수
        {
            if (s.Length == 1)
            {
                answer = s[0].ToString();
            }
            else
            {
                answer = s[s.Length / 2].ToString();
            }
        }
        else // 짝수
        {
            answer = s[(s.Length / 2) - 1].ToString() + s[s.Length / 2].ToString();
        }

        return answer;
    }
}
