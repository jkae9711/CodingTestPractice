// #26 : 콜라츠 추측

public class Solution
{
    public int solution(int num)
    {
        if (num == 1) return 0;

        ulong iTempOP = (ulong)num;
        int iCount = 0;

        while(true)
        {
            if (iTempOP % 2 == 0) iTempOP /= 2;
            else iTempOP = ((iTempOP * 3) + 1);

            iCount++;

            if (iCount > 500) return -1;
            if (iTempOP == 1) return iCount;
        }
    }
}