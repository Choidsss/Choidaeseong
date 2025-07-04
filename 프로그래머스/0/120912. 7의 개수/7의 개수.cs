using System;

public class Solution {
    public int solution(int[] array)
  {
    int answer = 0;

    for (int i=0;i<array.Length;i++)
    {
        foreach (char c in array[i].ToString())
        {
            if (c == '7')
            {
                answer++;
            }
        }
    }
    return answer;
  }
}