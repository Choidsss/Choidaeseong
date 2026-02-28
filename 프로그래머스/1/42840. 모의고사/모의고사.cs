using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
        List<int> correctArr = new List<int>();
        List<int> result = new List<int>();
        int[] answer = new int[] { };
        int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] arr3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        

        for (int i=0;i<answers.Length;i++)
        {
            if (answers[i] == arr1[i % arr1.Length])
            {
                num1++;
            }
            if (answers[i] == arr2[i % arr2.Length])
            {
                num2++;
            }
            if (answers[i] == arr3[i % arr3.Length])
            {
                num3++;
            }
        }
        correctArr.Add(num1);
        correctArr.Add(num2);
        correctArr.Add(num3);

        int maxValue = correctArr.Max();

        if (correctArr[0] == maxValue)
        {
            result.Add(1); 
        }
        if (correctArr[1] == maxValue)
        {
            result.Add(2);
        }
        if (correctArr[2] == maxValue)
        {
            result.Add(3);
        }

        return answer = result.ToArray();
    }
}