using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2];
        int correct = 0;
        int Maxresult = 0;
        int ZeroCount = lottos.Count( (x) => x == 0);

        for (int i=0;i<lottos.Length;i++)
        {
            if (lottos.Contains(win_nums[i]))
            {
                correct++;
            }
        }


        //몇등인지를 알려주는 코드
        Maxresult = ZeroCount + correct;
        answer[1] = correct;

        switch(Maxresult)
        {
            case 6:
                answer[0] = 1;
                break;
            case 5:
                answer[0] = 2;
                break;
            case 4:
                answer[0] = 3;
                break;
            case 3:
                answer[0] = 4;
                break;
            case 2:
                answer[0] = 5;
                break;
            default :
                answer[0] = 6;
                break;
        }

        switch (correct)
        {
            case 6:
                answer[1] = 1;
                break;
            case 5:
                answer[1] = 2;
                break;
            case 4:
                answer[1] = 3;
                break;
            case 3:
                answer[1] = 4;
                break;
            case 2:
                answer[1] = 5;
                break;
            default:
                answer[1] = 6;
                break;
        }
        return answer;
    }
}