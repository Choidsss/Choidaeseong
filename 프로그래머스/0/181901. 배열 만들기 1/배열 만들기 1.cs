using System;

public class Solution
{
    public int[] solution(int n, int k)
    {
        int index=0;
        int len=0;
        for (int i = 1; i <= n; i++)
        {
            if (i % k == 0)
            {
                len++;
            }
        }
        
        int[] answer = new int[len];

        for (int j=1;j<=n;j++)
        {
            if (j%k==0)
            {
                answer[index++] += j;
            }
        }
        return answer;
    }
}