using System;

public class Solution
{
    public int solution(int order)
    {
        int answer = 0;
        string numbers="";

        numbers = order.ToString();

        foreach (char c in numbers)
        {
            if (c=='3'||c=='6'||c=='9')
            {
                answer++;
            }
        }
        return answer;
    }
}