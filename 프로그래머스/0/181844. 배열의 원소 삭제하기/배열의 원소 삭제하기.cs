using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[] delete_list)
    {
        int[] answer = new int[] { };
        List<int> num = new List<int>();
        
        for (int i=0;i<arr.Length;i++)
        {
            num.Add(arr[i]); 
        }

        for (int j = 0; j < delete_list.Length; j++)
        {
            if (num.Contains(delete_list[j]))
            {
                num.Remove(delete_list[j]);
            }
        }
        answer = num.ToArray();
        return answer;
    }
}