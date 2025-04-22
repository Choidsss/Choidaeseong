using System;

public class Solution
{
    public string[] solution(string[] names)
    {
        int index = 0;
        int len = 0;

        for (int j = 0; j < names.Length; j++)
        {
            if (j % 5 == 0)
            {
                len++;
            }
        }

        string[] answer = new string[len];

        for (int i=0;i<names.Length;i++)
        {
            if (i%5==0)
            {
                answer[index]=names[i];
                index++;
            }
        }
        return answer;
    }
}