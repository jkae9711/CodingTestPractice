// #32 : 이상한 문자 만들기

using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        string[] arrInput = (from word in s
                             select word.ToString()).ToArray();

        int iCount = 0;

        for (int index = 0; index < arrInput.Length; index++)
        {
            if (arrInput[index] == " ")
            {
                iCount = 0;

                continue;
            }

            if (iCount % 2 == 0)
                arrInput[index] = arrInput[index].ToUpper();
            else
                arrInput[index] = arrInput[index].ToLower();

            iCount++;
        }

        return string.Join("", arrInput);
    }
}