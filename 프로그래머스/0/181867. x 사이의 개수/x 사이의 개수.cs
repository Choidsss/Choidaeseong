using System;

public class Solution
{
    public int[] solution(string myString)
    {
        int count = 0;
        string[] numArr = new string[] { };
        numArr = myString.Split('x');

        for (int j=0;j<numArr.Length;j++)
        {
            count++;
        }

        int[] answer = new int[count];

        for (int i=0;i<numArr.Length;i++)
        {
            answer[i] = numArr[i].Length;
        }
        return answer;
    }
}