using System;

public class Solution
{
    public int solution(int[,] arr)
    {
        int answer = 0;
        int count = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == arr[j, i])
                {
                    count++;
                }
                else break;
            }
        }

        if (count == arr.Length)
        {
            answer = 1;
        }
        else answer = 0;

        return answer;
    }
}