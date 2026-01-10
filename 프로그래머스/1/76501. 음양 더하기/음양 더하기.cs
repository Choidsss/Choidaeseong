using System;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 123456789;
        int plus = 0;
        int minus = 0;

        for (int i =0;i<signs.Length; i++)
        {
            if (signs[i] == true)
            {
                plus += absolutes[i];
            }
            else
            {
                minus -= absolutes[i];
            }
        }
        answer = minus + plus;
        return answer;
    }
}