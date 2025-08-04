using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        int spaceCnt = s.Count((x) => x == ' ');

        string[] str = new string[s.Length-spaceCnt];

        str = s.Split(' ');

        for (int i=0;i<str.Length;i++)
        {
            if (str[i] == "Z")
            {
                answer -= int.Parse(str[i - 1]); 
            }
            else
            {
                answer += int.Parse(str[i]);
            }
        }
        return answer;
    }
}