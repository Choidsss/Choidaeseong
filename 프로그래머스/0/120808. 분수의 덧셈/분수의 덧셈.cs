using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        List<int> list = new List<int>();
        int[] answer = new int[2];
        int addNumer = numer1 * denom2 + numer2 * denom1;
        int number = 0;

        for (int i = addNumer;i >= 1;i--)
        {
            if (addNumer % i == 0)
            {
                list.Add(i);
            }
        }

        for (int j = 0;j < list.Count; j++)
        {
            if (denom1 * denom2 % list[j] == 0)
            {
                number = list[j];
                break;
            }
        }

        if (number == 0)
        {
            answer[0] = addNumer;
            answer[1] = denom1 * denom2;
        }
        else
        {
            answer[0] = addNumer / number;
            answer[1] = denom1 * denom2 / number;
        }

        return answer;
    }
}