using System;

public class Solution
{
    public int solution(int n, string control)
    {
        int answer = n;

        foreach(char c in control)
        {
            if (c.ToString()=="w")
            {
                answer++; ;
            }
            else if (c.ToString() == "s")
            {
                answer--;
            }
            else if (c.ToString() == "d")
            {
                answer += 10;
            }
            else if (c.ToString() == "a")
            {
                answer -= 10;
            }
        }
        return answer;
    }
}
