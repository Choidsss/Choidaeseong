using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] solution(string myStr)
    {
        List<string> str = new List<string>();
        string[] answer = new string[] { };
        string letter = "";

        if (myStr.All((x) => x == 'a' || x == 'b' || x == 'c'))
        {
            return new string[1] { "EMPTY" };
        }
        else
        {
            for (int i=0;i<myStr.Length;i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'b' || myStr[i] == 'c')
                {
                    if (letter != null)
                    {
                        str.Add(letter);
                        letter = "";
                    }
                }
                else
                {
                    letter += myStr[i];
                }
            }

            if (letter != null)
            {
                str.Add(letter);
            }
            str.RemoveAll((x) => x == "");
        }
        answer = str.ToArray();
            return answer;
    }
}