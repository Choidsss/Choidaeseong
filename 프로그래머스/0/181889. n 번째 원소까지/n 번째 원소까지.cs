using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int[] answer = new int[] { };
        List<int> numbers = new List<int>();

        for (int i=0;i<n;i++)
        {
            numbers.Add(num_list[i]);
        }
        answer = numbers.ToArray();
        return answer;
    }
}