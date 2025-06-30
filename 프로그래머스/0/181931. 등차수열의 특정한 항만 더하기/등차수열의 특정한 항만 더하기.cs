using System;

public class Solution
{
    public int solution(int a, int d, bool[] included)
    {
        int[] numbers = new int[included.Length];
        int cnt = 0;
        int index = 0;
        int answer = 0;

        while (cnt < included.Length)
        {
           numbers[index] = a;
           a += d;
           index++;
           cnt++;
        }

        for (int i=0;i<included.Length;i++)
        {
            if (included[i] == true)
            {
                answer += numbers[i];
            }
        }
        return answer;
    }
}