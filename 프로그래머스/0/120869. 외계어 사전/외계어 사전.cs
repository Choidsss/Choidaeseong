using System;
using System.Collections.Generic;
using System.Linq;


public class Solution
{
    public int solution(string[] spell, string[] dic)
    {
        int answer = 0;
        
        for (int i = 0; i < dic.Length; i++)
        {
            bool y = spell.All((x) => dic[i].Count((a) => a.ToString() == x) == 1);

            if (y == true)
            {
                answer = 1;
                break;
            }
            else
            {
                answer = 2;
            }
        }
        return answer;
    }
}