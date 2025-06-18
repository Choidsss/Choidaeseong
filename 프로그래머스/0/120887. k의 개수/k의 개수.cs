using System;

public class Solution
{
    public int solution(int i, int j, int k)
    {
        int cnt = 0;
        int index = 0;
        int answer = 0;
        string[] numStr = new string[j - i + 1];

        for (int number = i; number <= j; number++)
        {
            numStr[index++] += number.ToString();
        }

        foreach (string str in numStr)
        {
            foreach (char c in str)
            {
                if (int.Parse(c.ToString())==k)
                {
                    cnt++;
                }
            }
        }
        answer = cnt;
        return answer;
    }
}