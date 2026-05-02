using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        StringBuilder builder = new StringBuilder();
        string answer = "";
        int[] choice = new int[7] { 3,2,1,0,1,2,3 };

        dic.Add('R', 0);
        dic.Add('T', 0);
        dic.Add('C', 0);
        dic.Add('F', 0);
        dic.Add('J', 0);
        dic.Add('M', 0);
        dic.Add('A', 0);
        dic.Add('N', 0);

        for (int i = 0;i<survey.Length;i++)
        {
            string str = survey[i];
            bool IsIndexThree = choices[i] <= 3 ? true : false;

            foreach (char c in survey[i])
            {
                if (IsIndexThree && c == str[0])
                {
                    dic[c] += choice[choices[i] - 1];
                    break;
                }
                else if(!IsIndexThree && c == str[1])
                {
                    dic[c] += choice[choices[i] - 1];
                }
            }
        }

        if (dic['R'] != dic['T'])
        {
            if (dic['R'] > dic['T'])
            {
                builder.Append('R');
            }
            else
            {
                builder.Append('T');
            }
        }
        else
        {
            builder.Append('R');
        }

        if (dic['C'] != dic['F'])
        {
            if (dic['C'] > dic['F'])
            {
                builder.Append('C');
            }
            else
            {
                builder.Append('F');
            }
        }
        else
        {
            builder.Append('C');
        }

        if (dic['J'] != dic['M'])
        {
            if (dic['J'] > dic['M'])
            {
                builder.Append('J');
            }
            else
            {
                builder.Append('M');
            }
        }
        else
        {
            builder.Append('J');
        }

        if (dic['A'] != dic['N'])
        {
            if (dic['A'] > dic['N'])
            {
                builder.Append('A');
            }
            else
            {
                builder.Append('N');
            }
        }
        else
        {
            builder.Append('A');
        }
        answer = builder.ToString();
        return answer;
    }
}