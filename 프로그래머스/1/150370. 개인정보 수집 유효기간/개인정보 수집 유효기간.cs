using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string today, string[] terms, string[] privacies)
    {
        Dictionary<char, int> termsDic = new Dictionary<char, int>();
        List<int> resultList = new List<int>();

        int[] answer = new int[] { };
        string[] todayArr = today.Split('.');
        int thisYear = int.Parse(todayArr[0]);
        int thisMonth = int.Parse(todayArr[1]);
        int thisDay = int.Parse(todayArr[2]);
        int todayTotalDays = 28 * thisMonth + thisDay + 28 * 12 * thisYear; 
        
        for (int i=0;i<terms.Length;i++)
        {
            string[] termsArr = terms[i].Split(' ');
            termsDic.Add(Convert.ToChar(termsArr[0]), int.Parse(termsArr[1]));
        }

        for (int i = 0;i<privacies.Length;i++)
        {
            string[] privacyArr = privacies[i].Split(' ');
            string[] strArr = privacyArr[0].Split('.');
            char key = Convert.ToChar(privacyArr[1]);

            int year = int.Parse(strArr[0]);
            int month = int.Parse(strArr[1]);
            int day = int.Parse(strArr[2]);

            int totalDays = 28 * 12 * year + month * 28 + day + termsDic[key] * 28;

            if (todayTotalDays >= totalDays)
            {
                resultList.Add(i+1);
            }
            else
            {
                continue;
            }
        }
        answer = resultList.ToArray();

        return answer;
    }
}