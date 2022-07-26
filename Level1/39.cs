// #39 : 부족한 금액 계산하기

class Solution
{
    public long solution(int price, int money, int count)
    {
        long lPriceSum = 0;
        long lPrice = price;
        long lMoney = money;

        for (long lCount = 1; lCount <= count; lCount++)
            lPriceSum += lPrice * lCount;

        if (lPriceSum - lMoney <= 0)
            return 0;
        else
            return lPriceSum - lMoney;

        // 등차수열의 합을 사용할수도 있음
    }
}