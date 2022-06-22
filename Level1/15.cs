// #15 : 문자열 다루기 기본

public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        int iTemp;

        if (s.Length != 4 && s.Length != 6)
        {
            answer &= false;
        }
        if (!int.TryParse(s, out iTemp))
        {
            answer &= false;
        }

        return answer;
    }
}