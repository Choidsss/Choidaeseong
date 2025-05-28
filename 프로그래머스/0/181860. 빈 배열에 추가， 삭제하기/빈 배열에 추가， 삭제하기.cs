using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, bool[] flag)
    {
        int[] answer = new int[] { };
        List<int> numArr = new List<int>();

        for (int i=0;i<flag.Length;i++)
        {
            int cnt = 0;
            int count = arr[i]*2;
            
            if (flag[i]==true)
            {
                while(cnt < count)
                {
                    cnt++;
                    numArr.Add(arr[i]);
                }
            }
            else
            {
                numArr.RemoveRange(numArr.Count - arr[i], arr[i]);
            }
        }
        answer = numArr.ToArray();
        return answer;
    }
}