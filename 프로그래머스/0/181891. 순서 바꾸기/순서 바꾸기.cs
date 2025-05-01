using System;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int index = 0;
        int[] numArr = new int[n];
        int[] answer = new int[num_list.Length];


        for (int j = 0; j < n; j++)
        {
            numArr[j] = num_list[j];
        }

        for (int i = n; i < num_list.Length; i++)
        {
            answer[index++] = num_list[i];
        }
        for (int k=0;k<numArr.Length;k++)
        {
            answer[index] = numArr[k];
            index++;
        }
        return answer;
    }
}