using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string message, int[,] spoiler_ranges)
    {
        HashSet<string> hashWords = new HashSet<string>();
        HashSet<string> hashNotSpolierWord = new HashSet<string>();
        int answer = 0;
        bool isSpoilerRange = false;
        string word = "";

        for (int i = 0; i < message.Length; i++)
        {
            char curAlpha = message[i];
            word += curAlpha.ToString();

            if (!isSpoilerRange && curAlpha == ' ')
            {
                word = word.Remove(word.Length - 1);
                hashNotSpolierWord.Add(word);
                isSpoilerRange = false;
                word = "";
                continue;
            }
            else if(isSpoilerRange && curAlpha == ' ')
            {
                isSpoilerRange = false;
                word = "";
                continue;
            }

            if (!isSpoilerRange)
            {
                for (int j = 0; j < spoiler_ranges.GetLength(0); j++)
                {
                    int start = spoiler_ranges[j, 0];
                    int end = spoiler_ranges[j, 1];

                    if (i >= start && i <= end)
                    {
                        isSpoilerRange = true;
                        break;
                    }
                }
            }
        }

        //마지막 단어 확인
        if(!isSpoilerRange && word != "")
        {
            hashNotSpolierWord.Add(word);
        }

        word = "";
        isSpoilerRange = false;

        for (int i = 0; i < message.Length; i++)
        {
            char curAlpha = message[i];
            word += curAlpha.ToString();

            if (isSpoilerRange && curAlpha == ' ')
            {
                word = word.Remove(word.Length - 1);
                
                if (!hashNotSpolierWord.Contains(word) && !hashWords.Contains(word))
                {
                    answer++;
                    hashWords.Add(word);
                }

                isSpoilerRange = false;
                word = "";
                continue;
            }
            else if(!isSpoilerRange && curAlpha == ' ')
            {
                isSpoilerRange = false;
                word = "";
                continue;
            }

            if (!isSpoilerRange)
            {
                for (int j = 0; j < spoiler_ranges.GetLength(0); j++)
                {
                    int start = spoiler_ranges[j, 0];
                    int end = spoiler_ranges[j, 1];

                    if (i >= start && i <= end)
                    {
                        isSpoilerRange = true;
                        break;
                    }
                }
            }
        }

        //마지막 단어 확인
        if (isSpoilerRange && word != "")
        {
            if (!hashNotSpolierWord.Contains(word) && !hashWords.Contains(word))
            {
                answer++;
            }
        }

        return answer;
    }
}