using System;

public class Solution
{
    public string[] solution(string[] names)
    {
        int len = names.Length % 5 == 0 ? names.Length / 5 : names.Length/5 + 1;

        string[] answer = new string[len];

        for (int i=0;i<len;i++)
        {
            answer[i] = names[i * 5];
        }
        return answer;
    }
}