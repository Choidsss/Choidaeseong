using System;

public class Solution
{
    public int[] solution(int n)
    {
        int index = 0;
        int len = 0;

        for (int j = 1; j <= n; j++)
        {
            if (n % j == 0)
            {
                len++;
            }
        }

        int[] answer = new int[len];
        
        for (int i=1;i<=n;i++)
        {
            if (n%i==0)
            {
                answer[index] += i;
                index++;
            }
        }
        return answer;
    }
}