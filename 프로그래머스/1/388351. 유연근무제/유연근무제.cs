using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] schedules, int[,] timelogs, int startday)
    {
        Dictionary<int, int> dicWorkersHopeSchedules = new Dictionary<int, int>();
        int answer = schedules.Length;

        for (int i = 0; i < schedules.Length; i++)
        {
            if (!dicWorkersHopeSchedules.ContainsKey(i))
            {
                int data = schedules[i] + 10;

                if (data % 100 >= 60)
                {
                    data = (data - data % 100 + 100) + data % 10;
                }
                dicWorkersHopeSchedules.Add(i, data);
            }
        }

        for (int i = 0; i < timelogs.GetLength(0); i++)
        {
            int start = startday;

            for (int j = 0; j < timelogs.GetLength(1); j++)
            {
                if (start == 6 || start == 7)
                {
                    if (start == 7)
                    {
                        start = 1;
                        continue;
                    }
                    start++;
                    continue;
                }

                if (timelogs[i, j] > dicWorkersHopeSchedules[i])
                {
                    answer--;
                    break;
                }
                start++;
            }
        }
        return answer;
    }
}