using System;

public class Solution
{
    public int solution(int num, int k)
    {
        int answer = 0;
        int index = 0;
        int[] numArr = new int[5];

        string numStr = num.ToString();
        foreach(char c in numStr)
        {
            index++;
            if(int.Parse(c.ToString()) == k)
            {
                answer = index;
                break;
            }
        }

        if(answer == 0)
        {
            answer = -1;
        }

        return answer;
    }
}