using System;

public class Solution
{
    public int[] solution(int n, int[] numlist)
    {
            int cnt = 0;

            for (int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {
                    cnt++;
                }
            }

            int[] answer = new int[cnt];

            for (int i = 0 ; i<numlist.Length;i++)
            {
                 if (numlist[i] % n == 0)
                 {
                    for(int j = 0; j < cnt; j++)
                    {
                        if(answer[j] == 0)
                        {
                            answer[j] = numlist[i];
                            break;
                        }                        
                    }                    
                 }
            }
            return answer;
    }
}