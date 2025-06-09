using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] intStrs, int k, int s, int l)
    {
        int index = 0;
        int[] answer = new int[] { };
        string[] str = new string[intStrs.Length];
        List<int> numbers = new List<int>();

        for (int i=0;i<intStrs.Length;i++)
        {
            str[index++] = intStrs[i].Substring(s, l);
        }
        
        for (int i=0;i<str.Length;i++)
        {
            if (int.Parse(str[i]) > k)
            {
                numbers.Add(int.Parse(str[i]));
            }
        }
        answer = numbers.ToArray();
        return answer;
    }
}