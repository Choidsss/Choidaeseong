using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int[,] intervals)
    {
        List<int> numbers = new List<int>();

        for (int i = intervals[0, 0]; i <= intervals[0,1];i++)
        {
            numbers.Add(arr[i]);
        }

        for (int j = intervals[1, 0]; j <= intervals[1, 1]; j++)
        {
            numbers.Add(arr[j]);
        }
        int[] answer = new int[numbers.Count];
        answer = numbers.ToArray();

        return answer;
    }
}