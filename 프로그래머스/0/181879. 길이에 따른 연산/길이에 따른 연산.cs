using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;

        if (num_list.Length < 11)
        {
            answer = 1;
            
            foreach(int i in num_list)
            {
                answer *= i;
            }
            //for (int j = 0; j < num_list.Length; j++)
            //{
            //    answer *= num_list[j];
            //}
        }
        else
        {
            foreach (int i in num_list)
            {
                answer += i;
            }
            //for (int i = 0; i < num_list.Length; i++)
            //{
            //    answer += num_list[i];
            //}
        }

        return answer;
    }
}