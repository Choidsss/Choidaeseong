using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        string answer = "";
        List<char> ch = new List<char>();

        Array.Sort(indices);

        for (int i=0;i<my_string.Length;i++)
        {
            ch.Add(my_string[i]);
        }

        for (int j = indices.Length-1; j >= 0; j--)
        {
            ch.RemoveAt(indices[j]);
        }
        answer = new string(ch.ToArray());
        return answer;
    }
}