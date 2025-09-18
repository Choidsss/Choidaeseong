using System;

public class Solution
{
    public string solution(string my_string, string overwrite_string, int s)
    {
        string answer = "";

        for (int i = 0; i < s; i++)
        {
            answer += my_string[i];
        }
        answer += string.Concat(overwrite_string);

        if (answer.Length < my_string.Length)
        {
            for (int i =answer.Length; i < my_string.Length;i++)
            {
                answer += my_string[i];
            }
        }

        return answer;
    }
}