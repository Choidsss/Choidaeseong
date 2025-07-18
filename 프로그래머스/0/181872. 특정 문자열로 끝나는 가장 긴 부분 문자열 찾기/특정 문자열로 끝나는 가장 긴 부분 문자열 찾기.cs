using System;

public class Solution
{
    public string solution(string myString, string pat)
    {
        string answer = "";
        int endIndex = 0;

        endIndex = myString.LastIndexOf(pat);

        for (int i=0;i<=endIndex+pat.Length-1;i++)
        {
            answer += myString[i];
        }
        return answer;
    }
}