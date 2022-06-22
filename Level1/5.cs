// #5 : 모의고사

using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        // 1 : (1, 2, 3, 4, 5), (1, 2, 3, 4, 5) ...
        // 2 : (2, 1, 2, 3, 2, 4, 2, 5), (2, 1, 2, 3, 2, 4, 2, 5) ...
        // 3 : (3, 3, 1, 1, 2, 2, 4, 4, 5, 5), (3, 3, 1, 1, 2, 2, 4, 4, 5, 5) ...

        int[] answer = new int[3];

        int[] Person1 = new int[10000];
        int[] Person2 = new int[10000];
        int[] Person3 = new int[10000];

        // Creating Person1
        for (int i = 0; i < answers.Length; i++)
        {
            switch (i % 5)
            {
                case 0: Person1[i] = 1; break;
                case 1: Person1[i] = 2; break;
                case 2: Person1[i] = 3; break;
                case 3: Person1[i] = 4; break;
                case 4: Person1[i] = 5; break;
            }
        }

        // Creating Person2
        for (int i = 0; i < answers.Length; i++)
        {
            if ((i % 8) % 2 == 0)
            {
                Person2[i] = 2;
            }
            else
            {
                switch (i % 8)
                {
                    case 1: Person2[i] = 1; break;
                    case 3: Person2[i] = 3; break;
                    case 5: Person2[i] = 4; break;
                    case 7: Person2[i] = 5; break;
                }
            }
        }

        // Creating Person3
        for (int i = 0; i < answers.Length; i++)
        {
            switch (i % 10)
            {
                case 0:
                case 1: Person3[i] = 3; break;
                case 2:
                case 3: Person3[i] = 1; break;
                case 4:
                case 5: Person3[i] = 2; break;
                case 6:
                case 7: Person3[i] = 4; break;
                case 8:
                case 9: Person3[i] = 5; break;
            }
        }

        // Searching
        int[] iCountHit = new int[3];

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == Person1[i])
            {
                iCountHit[0]++;
            }

            if (answers[i] == Person2[i])
            {
                iCountHit[1]++;
            }

            if (answers[i] == Person3[i])
            {
                iCountHit[2]++;
            }
        }

        int iMaxValue = iCountHit.Max();

        for (int i = 0; i < iCountHit.Length; i++)
        {
            if (iCountHit[i] == iMaxValue)
            {
                answer[i] = i + 1;
            }
        }

        // Result
        answer = answer.Where(x => x != 0).ToArray();
        Array.Sort(answer);

        return answer;
    }
}
