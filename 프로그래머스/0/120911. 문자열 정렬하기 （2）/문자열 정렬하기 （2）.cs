using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer= my_string;
        answer =answer.ToLower();
        char[] str = answer.ToCharArray();

        Array.Sort(str);

        return new string(str);
    }
}