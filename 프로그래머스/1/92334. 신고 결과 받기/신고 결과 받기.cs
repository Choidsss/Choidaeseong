using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        Dictionary<string, int> dicResultMail = new Dictionary<string, int>(); //신고한애들 관리
        Dictionary<string, int> dicReportMailManaged = new Dictionary<string, int>();//신고당한애 관리
        HashSet<string> hs = new HashSet<string>();
        int[] answer = new int[id_list.Length];
        int idx = 0;

        for (int i = 0; i < id_list.Length; i++)
        {
            answer[i] = 0;

            if (dicResultMail.ContainsKey(id_list[i]))
            {
                continue;
            }
            else
            {
                dicResultMail.Add(id_list[i], 0);
                dicReportMailManaged.Add(id_list[i], 0);
            }
        }

        for (int i = 0; i < report.Length; i++)
        {
            bool isAdd = hs.Add(report[i]);

            if (isAdd)
            {
                string[] str = report[i].Split(' ');
                dicReportMailManaged[str[1]]++;
            }
        }

        foreach (string words in hs)
        {
            string[] strs = words.Split(' ');
            if (dicReportMailManaged[strs[1]] >= k)
            {
                dicResultMail[strs[0]]++;
            }
        }

        foreach (KeyValuePair<string, int> kvp in dicResultMail)
        {
            answer[idx++] = kvp.Value;
        }
        return answer;
    }
}