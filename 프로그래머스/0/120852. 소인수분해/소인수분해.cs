using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int n)
    {
        //while 문을 쓰기
        //1. 1씩늘어나는 변수 i를 사용, i=2초기화, n%i반복, i 리스트에 저장
        //만약 나누어떨어지지 않는다면 i++ 후 다시 나누기 반복
        List<int> list = new List<int>();
        int[] answer = new int[] { };
        int i = 2;

        while(i <= n)
        {
            if (n%i==0)
            {
                list.Add(i);
                n = n / i;
            }
            else
            {
                i++;
            }
        }
        answer = list.Distinct().ToArray();
        return answer;
    }
}