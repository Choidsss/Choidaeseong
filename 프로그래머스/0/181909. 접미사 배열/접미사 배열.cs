using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        string[] answer = new string[] { };
        List<string> str = new List<string>();
        int index = 0;

        for (int i=0;i<my_string.Length;i++)
        {
            str.Add(my_string.Remove(0, i));
        }
        answer = str.ToArray();
        Array.Sort(answer);
        return answer;
    }
}