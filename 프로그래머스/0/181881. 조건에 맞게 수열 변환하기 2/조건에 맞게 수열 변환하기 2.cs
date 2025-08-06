using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] arr)
    {
        int answer = 0;
        bool stop = false;

        while (stop == false)
        {
            if(arr.Any(x => ((x >= 50)&&(x%2==0)) || ((x < 50) && (x % 2 != 0))))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] >= 50)
                    {
                        arr[i] = arr[i] / 2;
                        stop = false;
                    }
                    else if (arr[i] % 2 != 0 && arr[i] < 50)
                    {
                        arr[i] = arr[i] * 2 + 1;
                        stop = false;
                    }
                    else
                        stop = false;
                        continue;
                }
                answer++;
            }
            else
            {
                stop = true;
            }
        }
        return answer;
    }
}