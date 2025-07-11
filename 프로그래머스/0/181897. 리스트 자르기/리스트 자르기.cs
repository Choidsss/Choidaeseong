using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n, int[] slicer, int[] num_list)
    {
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];
        int[] answer = new int[] { };

        List<int> numbers = new List<int>();

        if (n==1)
        {
            for (int i=0;i<=b;i++)
            {
                numbers.Add(num_list[i]);
            }
        }
        else if (n==2)
        {
            for (int i = a ; i < num_list.Length ; i++)
            {
                numbers.Add(num_list[i]);
            }
        }
        else if (n==3)
        {
            for (int i = a; i <= b; i++)
            {
                numbers.Add(num_list[i]);
            }
        }
        else if (n==4)
        {
            for (int i = a; i <= b; i +=c)
            {
                numbers.Add(num_list[i]);
            }
        }
            return answer = numbers.ToArray();
    }
}