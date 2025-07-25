using System;

public class Solution
{
    public int solution(string[] order)
    {
        int answer = 0;

        for (int i=0;i<order.Length;i++)
        {
            if (order[i].Contains("americano"))
            {
                answer += 4500;
            }
            else if (order[i].Contains("cafelatte"))
            {
                answer += 5000;
            }
            else
            {
                answer += 4500;
            }
        }
        return answer;
    }
}