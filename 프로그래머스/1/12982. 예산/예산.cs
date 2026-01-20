using System;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;
        int initialValue = 0;

        Array.Sort(d);

        for (int i = 0; i < d.Length; i++)
        {
            initialValue += d[i];

            if (initialValue <= budget)
            {
                answer++;
            }
            else
            {
                break;
            }
        }
        return answer;
    }
}