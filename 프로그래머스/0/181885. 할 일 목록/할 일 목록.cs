using System;

public class Solution
{
    public string[] solution(string[] todo_list, bool[] finished)
    {
        int index = 0;
        int count = 0;

        for (int i = 0; i < finished.Length; i++)
        {
            if (finished[i]==true)
            {
                count++;
            }
        }
        
        string[] answer = new string[finished.Length- count];

        for (int i=0;i<finished.Length;i++)
        {
            if (finished[i]==false)
            {
                answer[index++] = todo_list[i];
            }
        }
        return answer;
    }
}