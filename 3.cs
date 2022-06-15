// #3 숫자 문자열과 영단어

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string s)
    {
        int iTemp = 0;
        List<int> lstNumber = new List<int>();
        int iCountCheck = -1;
        int iStart = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (int.TryParse(s[i].ToString(), out iTemp))
            {
                lstNumber.Add(iTemp);
                iCountCheck = i;
            }
            else
            {
                string strTemp = s.Substring(iCountCheck + 1, iStart);

                iStart++;

                for (int j = 0; j < 10; j++)
                {
                    if (strTemp.Equals(((stringOfNumber)j).ToString()))
                    {
                        lstNumber.Add(StringToInt(((stringOfNumber)j).ToString()));
                        iCountCheck = i;
                        iStart = 1;
                    }
                }
            }
        }

        string strListToString =
            String.Join("", lstNumber.ConvertAll(x => x.ToString()).ToArray());

        int answer;
        int.TryParse(strListToString, out answer);

        return answer;
    }

    enum stringOfNumber
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9
    }
 
    public static int StringToInt(string inputString)
    {
        switch (inputString)
        {
            case "zero": return 0;
            case "one": return 1;
            case "two": return 2;
            case "three": return 3;
            case "four": return 4;
            case "five": return 5;
            case "six": return 6;
            case "seven": return 7;
            case "eight": return 8;
            case "nine": return 9;
            default: return 0;
        }
    }
}
