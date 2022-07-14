// #31 : 정수 내림차순으로 배치하기

using System;
using System.Linq;

public class Solution
{
    public long solution(long n)
    {
        var temp = from value in n.ToString()
                   orderby value descending
                   select value.ToString();

        var temp2 = temp.ToArray();

        var temp3 = String.Join("", temp2);

        return Convert.ToInt64(temp3);

        //return
        //    Convert.ToInt64(
        //        String.Join("",
        //        (from value in n.ToString()
        //        select value.ToString())
        //        .Reverse()
        //        .ToArray()
        //        ));
    }
}