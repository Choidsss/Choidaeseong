using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int l, int r)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();

        for (int i=l;i <= r;i++)
        {
            string str = "";

            foreach (char c in i.ToString())
            {
                if(c == '5' || c == '0')
                {
                    str += c.ToString();
                }
            }

            if (str == i.ToString())
            {
                list.Add(i);
            }
            else
            {
                continue;
            }
        }

        if (list.Count != 0)
        {
            answer = list.ToArray();
            Array.Sort(answer);
        }
        else
        {
            list.Add(-1);
            answer = list.ToArray();
            Array.Sort(answer);
        }
            

        return answer;
    }
}