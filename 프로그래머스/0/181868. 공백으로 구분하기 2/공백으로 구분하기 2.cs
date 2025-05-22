using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        string[] answer = new string[] { };
        string[] letter = new string[] { };
        List<string> str = new List<string>();
        letter = my_string.Split(' ');

        for (int i = 0; i < letter.Length; i++)
        {
            if (letter[i] == "")
            {
                continue;
            }
            else
            {
                str.Add(letter[i].Trim());
            }
        }
        answer = str.ToArray();
        return answer;
    }
}