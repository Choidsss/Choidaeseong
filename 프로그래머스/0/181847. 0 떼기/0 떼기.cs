using System;

public class Solution
{
    public string solution(string n_str)
    {
        string answer = "";
        int a = 0;

        for (int i=0;i<n_str.Length;i++)
        {
            if (n_str[i]!='0')
            {
                a = i;
                break;
            }
        }
        for (int j=a;j<n_str.Length;j++)
        {
            answer += n_str[j];
        }
        return answer;
    }
}