using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();
        
        for(int i = 0; i < arr.Length; i++)
        {
            list.Add(arr[i]);
        }
        Array.Sort(arr);
        int deleteNum = arr[0];

        int index = list.FindIndex((x) => x == deleteNum);
        list.RemoveAt(index);

        if(list.Count == 0)
        {
            list.Add(-1);
        }
        answer = list.ToArray();

        return answer;
    }
}