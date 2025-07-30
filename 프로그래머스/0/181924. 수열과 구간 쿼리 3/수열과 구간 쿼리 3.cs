using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int temp = 0;
        int[] answer = new int[] { };

        for (int i=0;i<queries.GetLength(0);i++)
        {
            int index1 = queries[i, 0];
            int index2 = queries[i, 1];
            temp = arr[index1];

            arr[index1] = arr[index2];
            arr[index2] = temp;

            temp = 0;
        }
        return arr;
    }
}