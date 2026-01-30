using System;

public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";
        string copyStr = "";
        int[] foodNum = new int[food.Length];

        for (int i = 1; i < food.Length; i++)
        {
            if (i > 0 && food[i] > 1)
            {
                foodNum[i] = food[i] / 2;
            }
            else
            {
                foodNum[i] = 0;
            }
        }

        for (int i = 1; i < foodNum.Length; i++)
        {
            for (int j = 0; j < foodNum[i]; j++)
            {
                if (foodNum[i] != 0)
                {
                    answer += i.ToString();
                }
                else
                {
                    continue;
                }
            }
        }

        copyStr = answer.Substring(0);
        answer += "0";

        for (int i = copyStr.Length - 1; i >= 0; i--)
        {
            answer += copyStr[i];
        }
        return answer;
    }
}