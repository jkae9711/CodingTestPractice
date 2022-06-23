// #20 : 핸드폰 번호 가리기

using System.Text;

public class Solution
{
    public string solution(string phone_number)
    {
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < phone_number.Length - 4; i++)
        {
            answer.Append('*');
        }

        return answer
            .Append(phone_number.Substring(phone_number.Length - 4, 4))
            .ToString();
    }
}