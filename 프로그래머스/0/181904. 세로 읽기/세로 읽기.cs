using System;

public class Solution
{
    public string solution(string my_string, int m, int c)
    {
        int count = 0;
        int index = 0;
        int len = 0;
        string answer = "";

        len = my_string.Length / m;
        string[] str = new string[len];

        for (int i=0;i<my_string.Length;i++)
        {
            count++;
            str[index] += my_string[i];
            if (count==m)
            {
                count = 0;
                index++;
            }
        }
        
        for (int j=0;j<str.Length;j++)
        {
            answer += str[j].Substring(c - 1, 1);  
        }
        return answer;
    }
}