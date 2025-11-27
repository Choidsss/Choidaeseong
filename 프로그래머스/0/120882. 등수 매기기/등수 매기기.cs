using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[,] score)
    {
        int[] sortArr = new int[score.GetLength(0)];
        int[] copyArr = new int[score.GetLength(0)];
        int[] answer = new int[score.GetLength(0)];
        Dictionary<int, int> pairs = new Dictionary<int, int>(); 
        int num = 1;

        for (int i = 0; i < score.GetLength(0); i++)
        {
            int engScore = score[i, 0];
            int mathScore = score[i, 1];
            sortArr[i] = (engScore + mathScore);
            copyArr[i] = (engScore + mathScore);
        }
        Array.Sort(sortArr);
        Array.Reverse(sortArr);

        for (int i = 0; i < sortArr.Length;i++)
        {
            if (pairs.ContainsKey(sortArr[i]))
            {
                num++;
                continue;
            }
            else
            {
                pairs.Add(sortArr[i], num);
                num++;
            }
        }

        for (int i = 0; i < copyArr.Length; i++)
        {
            pairs.TryGetValue(copyArr[i], out int value);
            answer[i] = value;
        }

        return answer;
    }
}