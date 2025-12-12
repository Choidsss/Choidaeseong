using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            list.Add(arr[i]);
        }

        for (int i = 0; i < query.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (query[i] == list.Count - 1)
                {
                    continue;
                }
                else
                {
                    list.RemoveRange(query[i] + 1, list.Count - (query[i] + 1));
                }
                    
            }
            else
            {
                if (query[i] == 0)
                {
                    continue;
                }
                else
                {
                    list.RemoveRange(0, query[i]);
                }
                
            }
        }
        answer = list.ToArray();
        return answer;
    }
}