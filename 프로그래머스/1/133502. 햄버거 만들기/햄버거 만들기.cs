using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] ingredient)
    {
        List<int> list = new List<int>();

        int answer = 0;

        for (int i = 0;i<ingredient.Length;i++)
        {
            list.Add(ingredient[i]);

            if (list.Count > 3)
            {
                int n = list.Count;
                if (list[n-4] == 1 && list[n - 3] == 2 && list[n - 2] == 3 && list[n-1] == 1)
                {
                    list.RemoveRange(n - 4, 4);
                    answer++;
                }
                else
                {
                    continue;
                }
            }
        }
        return answer;
    }
}