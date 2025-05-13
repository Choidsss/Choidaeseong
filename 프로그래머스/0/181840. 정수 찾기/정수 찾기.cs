using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] num_list, int n)
    {
        List<int> num = new List<int>();

        for (int i=0;i<num_list.Length;i++)
        {
            num.Add(num_list[i]);
        }
        int answer = num.Contains(n) ? 1 : 0;
        return answer;
    }
}