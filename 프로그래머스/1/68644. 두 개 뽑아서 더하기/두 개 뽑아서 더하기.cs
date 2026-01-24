using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();

        for (int i=0;i<numbers.Length;i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i != j && !list.Contains(numbers[i] + numbers[j]))
                {
                    list.Add(numbers[i] + numbers[j]);
                }
            }
        }
        answer = list.ToArray();
        Array.Sort(answer);
        return answer;
    }
}