using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;

        for (int i=0;i<num_list.Length;i++)
        {
            if (num_list[i]<0)
            {
                answer = Array.IndexOf(num_list, num_list[i]);
                break;
            }
            else
            {
                answer = -1;
            }
        }
        return answer;
    }
}