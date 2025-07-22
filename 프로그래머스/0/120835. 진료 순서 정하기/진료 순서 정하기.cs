using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] emergency)
    { 
        Dictionary<int, int> compare = new Dictionary<int, int>();
        int[] answer = new int[emergency.Length];
        int[] sequenceArr = new int[emergency.Length];
        int index = 0;

        emergency.CopyTo(sequenceArr, 0);
        Array.Sort(sequenceArr);
        Array.Reverse(sequenceArr);
        
        for (int j=0;j<sequenceArr.Length;j++)
        {
            compare.Add(sequenceArr[j], j + 1);
        }

        for (int i=0;i<emergency.Length;i++)
        {
            if (compare.TryGetValue(emergency[i], out int value))
            {
                answer[index++] = value;
            }
        }
            return answer;
    }
}