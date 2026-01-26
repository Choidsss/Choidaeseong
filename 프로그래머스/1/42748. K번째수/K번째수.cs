using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();
        List<int> ansList = new List<int>();

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int numI = commands[i, 0];
            int numJ = commands[i, 1];
            int numK = commands[i, 2];

            for (int j = numI; j <= numJ; j++)
            {
                list.Add(array[j-1]);
            }

            list.Sort();
            ansList.Add(list[numK - 1]);
            list.Clear();
        }

        answer = ansList.ToArray();
        return answer;
    }
}