using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> numList = new List<int>();
        int[] answer = new int[] { };
        int pow2 = 1;

        for (int i=0;i<arr.Length;i++)
        {
            numList.Add(arr[i]);
        }

        while (pow2 < arr.Length)
        {
            pow2 = pow2 * 2;
        }
        int num = pow2 - arr.Length;

        for (int i=0;i<num;i++)
        {
            numList.Add(0);
        }
        
        answer = numList.ToArray();
        return answer;
    }
}