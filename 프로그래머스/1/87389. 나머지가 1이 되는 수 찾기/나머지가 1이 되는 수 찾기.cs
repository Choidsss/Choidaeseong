using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if(n % i == 1)
            {
                list.Add(i);
            }
        }
        list.Sort();
        answer = list[0];

        return answer;
    }
}