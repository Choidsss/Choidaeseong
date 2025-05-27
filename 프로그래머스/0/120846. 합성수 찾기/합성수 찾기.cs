using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
         int answer = 0;
         List<int> num = new List<int>();

        for (int i=1;i<=n;i++)
        {
            int com = 0;
            for (int j=1;j<=i;j++)
            {
                if (i % j == 0)
                {
                    com++;
                    
                }
            }
            if (com >= 3)
            {
               num.Add(i);
               com = 0;
            }
        }
        answer = num.Count;
        return answer;
    }
}