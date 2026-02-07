using System;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[strings.Length];
        string[] strs = new string[strings.Length];
        bool[] isUsed = new bool[strings.Length];

        Array.Sort(strings);

        for (int i=0;i<strings.Length;i++)
        {
            string word = strings[i];
            strs[i] = word[n].ToString();
            isUsed[i] = false;
        }

        Array.Sort(strs);

        for (int i=0;i<strs.Length;i++)
        {
            for (int j=0;j<strings.Length;j++)
            {
                string word = strings[j];

                if (strs[i] == word[n].ToString() && isUsed[j] == false)
                {
                    answer[i] = strings[j];
                    isUsed[j] = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        return answer;
    }
}