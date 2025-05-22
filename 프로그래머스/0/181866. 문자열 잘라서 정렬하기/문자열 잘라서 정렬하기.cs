using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string myString)
    {
        string[] answer = new string[] { };
        List<string> str = new List<string>();
        answer = myString.Split('x');
        
        for (int i=0;i<answer.Length;i++)
        {
            if (answer[i]=="")
            {
                continue;
            }
            else
            {
                str.Add(answer[i]);
            }
        }
        str.Sort();
        answer = str.ToArray();
        return answer;
    }
}