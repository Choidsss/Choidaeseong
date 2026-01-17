using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();
        int index = 0;

        for (int i=0;i<arr.Length;i++)
        {
            if (arr[i] % divisor == 0)
            {
                list.Add(arr[i]);
            }
        }

        if(list.Count == 0)
        {
            answer = new int[1];
            answer[0] = -1;
        }
        else
        {
            answer = list.ToArray();
            Array.Sort(answer);
        }
        return answer;
    }
}