// #28 : 제일 작은 수 제거하기

using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int iMin = arr.Min();

        return
            arr.Length == 1 ?
            new int[] { -1 } :
            (from item in arr where item > iMin select item).ToArray();
    }
}