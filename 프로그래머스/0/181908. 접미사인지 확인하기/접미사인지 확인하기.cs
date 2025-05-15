using System;

public class Solution
{
    public int solution(string my_string, string is_suffix)
    {
        int answer = 0;

        if (my_string.EndsWith(is_suffix))
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