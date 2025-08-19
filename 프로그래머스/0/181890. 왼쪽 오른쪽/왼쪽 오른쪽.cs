using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        List<string> str = new List<string>();
        string[] answer = new string[] { };
        int indexL = Array.IndexOf(str_list, "l");
        int indexR = Array.IndexOf(str_list, "r");
        int low = 0;

        if (indexL != -1 && indexR != -1)
        {
            low = Math.Min(indexL, indexR);
        }
        else
        {
            if (indexL == -1)
            {
                low = indexR;
            }
            else if (indexR == -1)
            {
                low = indexL;
            }
        }


        if (low != -1 && low == indexL)
        {
            for (int i = 0; i < indexL; i++)
            {
                str.Add(str_list[i]);
            }
        }
        else if (low != -1 && low == indexR)
        {
            for (int i = indexR + 1; i < str_list.Length; i++)
            {
                str.Add(str_list[i]);
            }
        }
        else
        {
            str.Clear();
        }
            answer = str.ToArray();
            return answer;
    }
}