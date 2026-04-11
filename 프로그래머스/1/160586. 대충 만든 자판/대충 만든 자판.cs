using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];
        Dictionary<char, int> dic = new Dictionary<char, int>();


        for (int i = 0; i < keymap.Length; i++)
        {
            string str = keymap[i];

            for (int j = 0; j < str.Length; j++)
            {
                if (!dic.ContainsKey(str[j]))
                {
                    dic.Add(str[j], j + 1);
                }
                else
                {
                    if (dic[str[j]] > j)
                    {
                        dic[str[j]] = j + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        for (int i = 0; i < targets.Length; i++)
        {
            string targetStr = targets[i];
            int sum = 0;
            bool isPossible = true;

            for (int j = 0; j < targetStr.Length; j++)
            {
                if (dic.ContainsKey(targetStr[j]))
                {
                    sum += dic[targetStr[j]];
                }
                else
                {
                    isPossible = false;
                    break;
                }
            }
            answer[i] = isPossible ? sum : -1;
        }
        return answer;
    }
}