using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        int[] answer = new int[] { };
        List<int> num = new List<int>();
        num.Add(n);

        while (n>1)
        {
            if (n % 2 == 0)
            {
                num.Add(n / 2);
                n = n / 2;
            }
            else
            {
                num.Add(3 * n + 1);
                n = 3 * n + 1;
            }
        }
        answer = num.ToArray();
        return answer;
    }
}