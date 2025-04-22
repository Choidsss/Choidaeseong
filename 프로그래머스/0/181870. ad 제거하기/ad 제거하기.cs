using System;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        int len = 0;
        for (int j = 0; j < strArr.Length; j++)
        {
            if (strArr[j].Contains("ad"))
            {
                len++;
            }
        }
        string[] answer = new string[strArr.Length - len];
        int index = 0;
        for (int i = 0; i < strArr.Length; i++)
        {
            if (!strArr[i].Contains("ad"))
            {
                answer[index++] = strArr[i];
            }
            //else
            //{
            //    answer[i] = strArr[i];
            //}
        }
        return answer;
    }
}
