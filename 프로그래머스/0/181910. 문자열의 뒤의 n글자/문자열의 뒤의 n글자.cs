using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = "";
        int len = my_string.Length - n;

        for (int i = len;i<my_string.Length;i++)
        {
            answer += my_string[i];
        }
        return answer;
    }
}