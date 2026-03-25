using System;

public class Solution
{
    public int solution(string s)
    {
        string alphabet = "";
        int answer = 0;
        int x = 0;
        int not_x = 0;

        for (int i = 0;i<s.Length;i++)
        {
            if (alphabet == "")
            {
                alphabet += s[i].ToString();
            }

            if (s[i].ToString() == alphabet)
            {
                x++;
            }
            else
            {
                not_x++;
            }

            if (x == not_x)
            {
                answer++;
                x = 0;
                not_x = 0;
                alphabet = "";
            }
        }

        if (x != not_x)
        {
            answer++;
        }
        return answer;
    }
}