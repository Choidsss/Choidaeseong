using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        List<int> list = new List<int>();
        int answer = n - lost.Length;

        Array.Sort(lost);
        Array.Sort(reserve);

        for (int i = 0; i < lost.Length; i++)
        {
            if (reserve.Contains(lost[i]))
            {
                list.Add(lost[i]);
                answer++;
            }
        }

        //answer = 2인 상태
        //숫자를 썼는지 안썼는지에 대한 여부를 알려주는게 필요
        for (int i = 0; i < lost.Length; i++)
        {
            bool isIn = false;

            for (int k = 0; k < list.Count; k++)
            {
                if (list[k] == lost[i])
                {
                    isIn = true;
                    break;
                }
            }

            if (isIn == true)
            {
                continue;
            }

            for (int j = 0; j < reserve.Length; j++)
            {
                if (list.Contains(reserve[j]))
                {
                    continue;
                }

                if (lost[i] >= reserve[j] - 1 && lost[i] <= reserve[j] + 1)
                {
                    answer++;
                    lost[i] = -1;
                    reserve[j] = -1;
                    break;
                }
            }
        }
        return answer;
    }
}