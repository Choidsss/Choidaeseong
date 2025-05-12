using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        string str = "";

        foreach (char c in myString)
        {
            if (c == 'A')
            {
                str += "B";
            }
            else if(c=='B')
            {
                str += "A";
            }
        }

        if (str.Contains(pat))
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
            return answer;
    }
}