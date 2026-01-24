using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        List<int> list = new List<int>();
        int answer = 0;
        int remain = 0;

        while (n > 0)
        {
            remain = n % 3;
            list.Add(remain);
            n = n / 3;
        }
        list.Reverse();

        for (int i = 0; i < list.Count; i++)
        {
            answer += (int)Math.Pow(3, i) * list[i];
        }
        return answer;
    }
}