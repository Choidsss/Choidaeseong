using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        int cnt = 0;
        bool flag = false;
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i=0;i<array.Length;i++)
        {
            if (dic.ContainsKey(array[i]))
            {
                dic[array[i]]++;
            }
            else
            {
                dic.Add(array[i], 1);
            }
        }

        int maxValue = dic.Values.Max();

        foreach (KeyValuePair<int, int> pairs in dic)
        {             
            if (pairs.Value == maxValue)
            {
                cnt++;
                answer = pairs.Key;

                if (cnt == 2)
                {
                    flag = true;
                    break;
                }
                continue;
            }
        }

        if (array.Length == 1)
        {
            answer = array[0];
        }
        else if (flag || maxValue == 1)
        {
            answer = -1;
        }
        return answer;
    }
}