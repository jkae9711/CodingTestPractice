// #33 : 시저 암호

using System.Linq;

public class Solution
{
    public string solution(string s, int n)
    {
        // 65 ~ 90 : Upper
        // 97 ~ 122 : Lower

        var arrInput = (from word in s
                    select word).ToArray();

        for (int index = 0; index < arrInput.Length; index++)
        {
            int iAsciiNumber = (int)arrInput[index];

            if (65 <= iAsciiNumber && iAsciiNumber <= 90)
            {
                if (90 < iAsciiNumber + n)
                    arrInput[index] = (char)((iAsciiNumber + n) - 90 - 1 + 65);
                else
                    arrInput[index] = (char)(iAsciiNumber + n);
            }
            else if (97 <= iAsciiNumber && iAsciiNumber <= 122)
            {
                if (122 < iAsciiNumber + n)
                    arrInput[index] = (char)((iAsciiNumber + n) - 122 - 1 + 97);
                else
                    arrInput[index] = (char)(iAsciiNumber + n);
            }
            else // 공백일 경우
            {
                continue;
            }
        }

        return string.Join("", arrInput);
    }
}