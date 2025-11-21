using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] sides)
    {
        int answer = 0;
        int sidesBigger = Math.Max(sides[0], sides[1]);
        int sidesSmaller = Math.Min(sides[0], sides[1]);
        int sidesAdd = sides[0] + sides[1];
        List<int> numbers = new List<int>(); 

        for (int i=1;i< sidesAdd;i++)
        {
            if (i > sidesBigger && i < sidesAdd)
            {
                numbers.Add(i);
            }
        }

        for (int i = 1; i <= sidesBigger; i++)
        {
            if (i > sidesBigger - sidesSmaller)
            {
                numbers.Add(i);
            }
        }

        numbers.Distinct();

        for (int i=0;i<numbers.Count;i++)
        {
            answer++;
        }
        return answer;
    }
}