using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        List<char> ch = new List<char>();
        Dictionary<char, int> str = new Dictionary<char, int>();

        foreach (char c in s)
        {
            char letter = c;
            if (str.ContainsKey(letter))
            {
                str[letter]++;
            }
            else
            {
                str[letter] = 1;
            }
        }

        foreach (var pair in str)
        {
            int targetValue = 1;
            if (pair.Value == targetValue)
            {
                ch.Add(pair.Key);
            }
            else
            {
                continue;
            }
        }
        ch.Sort();

        for (int i=0;i<ch.Count;i++)
        {
            answer += ch[i].ToString();
        }
        return answer;
    }
}