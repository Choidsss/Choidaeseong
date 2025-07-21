using System;

public class Solution
{
    public int solution(int[] array, int n)
{
    int answer = array[0];
    int num = Math.Abs(array[0] - n);

    for (int i = 0; i < array.Length; i++)
    {
        int compareNum = Math.Abs(array[i] - n);

        if (compareNum < num)
        {
            num = compareNum;
            answer = array[i];
        }
        else if (compareNum == num && array[i] < answer)
        {
            answer = array[i];
        }
    }

    return answer;
}
}