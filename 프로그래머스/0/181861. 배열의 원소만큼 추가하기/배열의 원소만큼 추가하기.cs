using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int number=0;
        int len = 0;
        foreach(int i in arr)
        {
            len += i;
        }
    
        int[] answer = new int[len];
        int index = 0;
        foreach(int i in arr)
        {
            for(int j = 0; j < i; j++)
            {
                answer[index++] = i;
            }
        }

        return answer;
    }
}