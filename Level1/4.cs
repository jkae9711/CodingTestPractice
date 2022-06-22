// #4 : K번째 수
 
using System;
using System.Collections;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[50];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int iStartIndex = commands[i, 0];
            int iEndIndex = commands[i, 1];
            int iResultIndex = commands[i, 2];

            int[] arrTempSlice = new int[100];

            Array.Copy(array, iStartIndex - 1,
                       arrTempSlice, 0, (iEndIndex - iStartIndex + 1));

            arrTempSlice = arrTempSlice.Where(x => x != 0).ToArray();

            Array.Sort(arrTempSlice);

            answer[i] = arrTempSlice[iResultIndex - 1];
        }

        answer = answer.Where(x => x != 0).ToArray();

        return answer;
    }
}
