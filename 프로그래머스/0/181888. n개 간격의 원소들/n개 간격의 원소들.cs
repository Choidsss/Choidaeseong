using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int[] answer = new int[] { };
        List<int> num = new List<int>();

        for (int i=0;i<num_list.Length;i++)
        {
            if (i%n==0)
            {
                num.Add(num_list[i]);
            }
        }
        answer = num.ToArray();
        return answer;
    }
}