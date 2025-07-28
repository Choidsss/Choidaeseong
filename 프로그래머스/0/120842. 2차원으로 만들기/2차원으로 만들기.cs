using System;

public class Solution
{
    public int[,] solution(int[] num_list, int n)
    {
        int n2 = n;
        int n1 = num_list.Length / n;
        int index = 0;
        int[,] answer = new int[n1,n2];

        for (int i=0;i < answer.GetLength(0);i++)
        {
            for (int j=0;j<answer.GetLength(1);j++)
            {
                answer[i, j] = num_list[index++]; 
            }
        }
        
        return answer;
    }
}