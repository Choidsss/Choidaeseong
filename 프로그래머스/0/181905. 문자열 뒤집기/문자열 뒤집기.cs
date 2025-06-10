using System;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        string answer = "";
        string str = "";

        for (int i=e;i>=s;i--)
        {
            str += my_string[i];
        }


        for (int i = 0; i < s; i++)
        {
            answer += my_string[i];
        }
        answer = answer.Insert(s, str);

        for (int j = e + 1; j < my_string.Length; j++)
        {
            answer += my_string[j];
        }
        return answer;
    }
}