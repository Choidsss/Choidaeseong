using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        string answer = "";

        for (int i = 0;i<s.Length;i++)
        {
            char alpha = s[i];
            int cnt = 0;

            while (cnt < index)
            {
                alpha++;

                if (alpha == '{')
                {
                    alpha = 'a';
                }

                if (skip.Contains(alpha.ToString()))
                {
                    continue;
                }
                else
                {
                    cnt++;    
                }
            }
            answer += alpha.ToString();
        }
        return answer;
    }
}