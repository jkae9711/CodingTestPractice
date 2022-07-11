// #23 : 문자열 내림차순으로 배치하기

using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        var lstTemp = (from word in s
                       orderby word
                       select word)
                      .ToList();

        lstTemp.Reverse();

        return new string(lstTemp.ToArray());
    }
}