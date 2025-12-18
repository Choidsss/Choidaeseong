using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] lines)
    {
        /*
         * 로직(겹치는 선분의 길이)
         * 선분의 길이를 한칸씩 나눠 놓음
         * 그 각 선분을 dic의 key값으로 넣음
         * 
         * 1. lines에서 하나씩 배열을 빼고
         * 2. 그 배열을 세분화를 시킨다.
         * 3. 
         *   3-1. 배열에 key값이 없으면? => key값 추가시키고, value값 1증가
         *   3-2. 있다면? => 그에 맞는 value값 증가
         * 4. value값이 2 이상인 애들의 value값을 가져와서 길이를 answer에 저장
         * 5. answer 리턴
         */
        int answer = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < lines.GetLength(0); i++)
        {
            //배열이 어느정도의 범위를 가지고 있는지 확인
            int start = lines[i, 0];
            int end = lines[i, 1];

            //start 부터 end까지 한칸씩 할당
            for (int j = start;j<end;j++)
            {
                if (dic.ContainsKey(j))
                {
                    dic[j]++;
                }
                else
                {
                    dic.Add(j, 1);
                }
            }
        }

        //value값이 2보다 큰 값이 있는지 확인
        foreach (KeyValuePair<int, int> pair in dic)
        {
            if (pair.Value > 1)
            {
                answer++;
            }
            else
            {
                continue;
            }
                
        }
        return answer;
    }
}