using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalPayment = 0;

        for (int i = 1;i<=count; i++)
        {
            totalPayment += price*i;
        }

        if (money < totalPayment)
        {
            return totalPayment - money;
        }
        else
        {
            return 0;
        } 
    }
}