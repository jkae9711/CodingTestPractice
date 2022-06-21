// #8 : 2016년

public class Solution
{
    public string solution(int a, int b)
    {
        string answer = "";

        // 2016년은 윤년이므로 2월달이 29일
        // 29일인 달 : 2
        // 30일인 달 : 4, 6, 9, 11
        // 31일인 달 : 3, 5, 7, 8, 10, 12 (1월 계산 안함)

        answer = GetDayOfTheWeek(GetDayCount(a, b) % 7);

        return answer;
    }

    // a월 b일과 1월 1일과의 차이(일 수)로 나타내는 요일
    public string GetDayOfTheWeek(int input)
    {
        switch (input)
        {
            case 0: return "FRI";
            case 1: return "SAT";
            case 2: return "SUN";
            case 3: return "MON";
            case 4: return "TUE";
            case 5: return "WED";
            case 6: return "THU";
            default: return string.Empty;
        }
    }

    public int GetDayCountOfMonth(int inputMonth)
    {
        switch (inputMonth)
        {
            case 3: return 29;

            case 5:
            case 7:
            case 10:
            case 12: return 30;

            case 2:
            case 4:
            case 6:
            case 8:
            case 9:
            case 11: return 31;

            default: return 0;
        }
    }

    public int GetDayCount(int a, int b)
    {
        int iResult = 0;

        for (int i = 2; i <= a; i++)
        {
            iResult += GetDayCountOfMonth(i);
        }

        iResult += b - 1;

        return iResult;
    }
}