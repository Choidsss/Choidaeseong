using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int a, int b, int c, int d)
    {
        int answer = 1;
        int[] arr = new int[4];
        List<int> list = new List<int>();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        arr[0] = a;
        arr[1] = b;
        arr[2] = c;
        arr[3] = d;
        int min = arr.Min();
        

        for (int i=0;i<arr.Length;i++)
        {
            if (dic.ContainsKey(arr[i]))
            {
                dic[arr[i]]++;
            }
            else
            {
                dic.Add(arr[i], 1);
                list.Add(arr[i]);
            }
        }

        int keyCount = dic.Keys.Count;

        if (keyCount == 1)
        {
            answer = 1111 * a;
        }
        else if (keyCount == 2)
        {
            int p_key = list[0];
            int q_key = list[1];
            int p_value = dic[list[0]];
            int q_value = dic[list[1]];

            if (p_value != 2)
            {
                if (p_value == 3)
                {
                    answer = (int)Math.Pow(10 * p_key + q_key, 2);
                }
                else
                {
                    answer = (int)Math.Pow(10 * q_key + p_key, 2);
                }
            }
            else
            {
                answer = (p_key + q_key) * Math.Abs(p_key - q_key);
            }
        }
        else if (keyCount == 3)
        {
            for (int i =0;i<list.Count;i++)
            {
                if (dic[list[0]] == 2)
                {
                    answer = list[1] * list[2];
                }
                else if(dic[list[0]] == dic[list[i]])
                {
                    answer = list[0] * list[i];
                }
            }
        }
        else
        {
            answer = min;
        }
        return answer;
    }
}