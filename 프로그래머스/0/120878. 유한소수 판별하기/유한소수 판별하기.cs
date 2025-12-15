using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int a, int b)
    {
        /*
         * 유한 소수 판별하기 (while 문 사용)
         * 
         * 1. 주어진 a,b 를 기약분수로 먼저 나타내기(분자: a, 분모: b)
         * 2. 기약 분수로 나타내었을때,
         *   2-1. 분모의 소인수가 2와5로만 존재하면 유한소수이고
         *   2-2. 그렇지 않으면 모두 무한소수
         * 3. 주어진 수가 유한소수로 나타낼수 있으면 answer = 1,
         *    그렇지 않으면 answer = 2,     
         *    리턴하기
         *    
         * 로직
         * 기약 분수로 먼저 나타내기 => 어떻게?
         * while문으로 분모 소인수 분해
         * 
         */
        List<int> denomList = new List<int>();
        List<int> numerList = new List<int>();
        int answer = 0;
        int number1 = b;
        int number2 = a;
        int n1 = 2;
        int n2 = 2;
        int cnt = 0;

        //분자 소인수분해
        while (n2 <= number2)
        {
            if (number2 % n2 == 0)
            {
                number2 = number2 / n2;
                numerList.Add(n2);
            }
            else
            {
                n2++;
            }
        }

        //분모 소인수분해
        while (n1 <= number1)
        {
            if (number1 % n1 == 0)
            {
                number1 = number1 / n1;
                denomList.Add(n1);
            }
            else
            {
                n1++;
            }
        }

        // *겹치는게 있는지 확인*
        for (int i =0;i<numerList.Count;i++)
        {
            if (denomList.Contains(numerList[i]))
            {
                denomList.Remove(numerList[i]);
            }
        }

        for (int i = 0;i<denomList.Count;i++)
        {
            if (denomList[i] == 2 || denomList[i] == 5)
            {
                continue;
            }
            else
            {
                cnt++;
            }
        }

        if(cnt != 0)
        {
            answer = 2;
        }
        else
        {
            answer = 1;
        }
        return answer;
    }
}