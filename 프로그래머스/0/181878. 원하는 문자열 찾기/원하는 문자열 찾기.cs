using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;

        myString = myString.ToLower();
        pat = pat.ToLower();

        if (myString.Contains(pat))
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
            return answer;
    }
}