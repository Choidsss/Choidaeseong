using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_str, int n)
    {
        List<string> str = new List<string>();
        string[] answer = new string[] { };
        int remain = my_str.Length % n;
        int quotient = my_str.Length / n;

        if (remain == 0)
        {
            for (int i=0;i<my_str.Length;i+=n)
            {
                str.Add(my_str.Substring(i, n));
            }
        }
        else
        {
            for (int i = 0; i < my_str.Length - remain; i += n)
            {
                str.Add(my_str.Substring(i, n));
            }
            str.Add(my_str.Substring(my_str.Length - remain, remain));

        }
        answer = str.ToArray();
        return answer;
    }
}