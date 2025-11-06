using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int balls, int share)
    {
        // 4C3 = 4C1
        // C*(n-k+1) / k => 공식
        List<long> numbers = new List<long>();
        long num1 = 1;
        long answer = 1;

        if (balls != share)
        {
            for (int i=1;i<=share;i++)
            {
                answer = answer * (balls - i + 1) / i;
            }  
        }
        else
        {
            answer = 1;
        }
        return (int)answer;
    }
}