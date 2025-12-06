using System;

public class Solution
{
    public int solution(int[] common)
    {
        int answer = 0;
        int difference1 = common[1] - common[0];
        int difference2 = common[2] - common[1];
        int differenceOrRatio = 0; // 1 = 등차, 2 = 등비

        if (difference1 == difference2)
        {
            differenceOrRatio = 1;
        }
        else
        {
            differenceOrRatio = 2;
        }

        if(differenceOrRatio == 1)
        {
            answer = common[common.Length - 1] + difference1;
        }
        else
        {
            answer = common[common.Length - 1] * common[1] / common[0];
        }
        return answer;
    }
}