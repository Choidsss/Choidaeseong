using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers, string direction)
    {
        int[] answer = new int[] { };
        List<int> num = new List<int>();

        if (direction=="right")
        {
            num.Add(numbers[numbers.Length-1]);
            for (int i=0;i<numbers.Length-1;i++)
            {
                num.Add(numbers[i]);
            }
        }
        else
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                num.Add(numbers[j]);
            }
            num.Add(numbers[0]);
        }
        answer = num.ToArray();
        return answer;
    }
}