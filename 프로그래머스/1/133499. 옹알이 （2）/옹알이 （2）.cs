using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] possible = new string[4] { "aya", "ye", "woo", "ma" };

        for (int i = 0;i<babbling.Length;i++)
        {
            string str = babbling[i].ToString();

            for (int j = 0;j<possible.Length;j++)
            {
                string isdouble = "";

                isdouble += possible[j];
                isdouble += possible[j];

                if (str.Contains(isdouble))
                {
                    isdouble = "";
                    continue;
                }
                else
                {
                    isdouble = "";
                }


                if (str.Contains(possible[j]))
                {
                    str = str.Replace(possible[j], " ");
                }
            }

            if (string.IsNullOrWhiteSpace(str)) 
            {
                answer++;
            } 
        }
        return answer;
    }
}