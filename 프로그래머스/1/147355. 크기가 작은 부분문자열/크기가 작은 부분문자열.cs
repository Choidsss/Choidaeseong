using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        int lastIndex = t.Length - p.Length;

        for (int i = 0; i <= lastIndex; i++)
        {
            string subStr = t.Substring(i, p.Length);

            if (long.Parse(subStr) <= long.Parse(p))
            {
                answer++;
            }
        }
        
        return answer;
    }
}