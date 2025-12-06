using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int num, int total)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();


        if (total == 0)
        {
            for (int i = -1000; i <= 1000; i++)
            {
                int cnt = 0;
                int magnitude = 0;


                for (int j = i; j <= 1000; j++)
                {
                    magnitude += j;
                    list.Add(j);
                    cnt++;

                    if (cnt == num && magnitude == total)
                    {
                        answer = list.ToArray();
                        break;
                    }
                    else if (cnt == num)
                    {
                        list.Clear();
                        break;
                    }
                }

                if (list.Count != 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        else
        {
            for (int i = -total; i <= total; i++)
            {
                int cnt = 0;
                int magnitude = 0;


                for (int j = i; j <= total; j++)
                {
                    magnitude += j;
                    list.Add(j);
                    cnt++;

                    if (cnt == num && magnitude == total)
                    {
                        answer = list.ToArray();
                        break;
                    }
                    else if (cnt == num)
                    {
                        list.Clear();
                        break;
                    }
                }

                if (list.Count != 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
            return answer;
    }
}