using System;

public class Solution
{
    public int[] solution(int start_num, int end_num)
    {
        int index = 0;
        int count=0;


        for (int i = start_num; i >= end_num; i--)
        {
            count++;
        }

        int[] answer = new int[count];

        for (int i=start_num;i>=end_num;i--)
        {
            answer[index++] = i;
        }
        return answer;
    }
}