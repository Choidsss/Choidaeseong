using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;
        int plus = 0;
        int multiply =1;

        for (int i=0;i<num_list.Length;i++)
        {
            multiply *= num_list[i];
        }
        for (int j=0;j<num_list.Length;j++)
        {
            plus += num_list[j];
        }

        if (multiply>plus * plus)
        {
            answer = 0;
        }
        else
        {
            answer = 1;
        }
            return answer;
    }
}