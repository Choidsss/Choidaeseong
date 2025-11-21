using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] picture, int k)
    {
        string[] answer = new string[picture.Length * k];
        string[] copyPicture = new string[picture.Length];
        List<string> copy = new List<string>();

        for (int i = 0; i < picture.Length; i++)
        {
            foreach (char c in picture[i])
            {
                for (int j = 0;  j < k; j++)
                {
                    copyPicture[i] += c.ToString();
                }
            }
        }

        for (int i = 0; i < copyPicture.Length; i++)
        {
            for (int j=0;j<k;j++)
            {
                copy.Add(copyPicture[i]);
            }
        }
        answer = copy.ToArray();
        return answer;
    }
}