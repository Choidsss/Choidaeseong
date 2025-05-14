using System;

public class Solution
{
    public int solution(string my_string, string is_prefix)
    {
        int answer = 0;

        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string.StartsWith(is_prefix)==true)
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }
        }
        return answer;
    }
}