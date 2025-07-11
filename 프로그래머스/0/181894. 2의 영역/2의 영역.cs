using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int index = 0;
        int index1 = -1;
        int index2 = -1;

        index1 = Array.IndexOf(arr, 2);

        for (int i = arr.Length-1; i > 0; i--)
        {
            if (arr[i] == 2)
            {
                index2 = i;
                break;
            }
        }


        int[] answer = new int[index2-index1+1];
        if (index1 == -1 && index2 == -1)
        {
            return new int[] {-1};
        }

        for (int i=index1;i<=index2;i++)
        {
            answer[index++] = arr[i];
        }
        return answer;
    }
}