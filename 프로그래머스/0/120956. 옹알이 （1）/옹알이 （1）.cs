using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        /*옹알이(중복 x)
         * 1. babbling에서 문자열을 Contain으로 확인(str이 있는지 확인)
         *  1-1. 있다면 그 문자열을 길이를 저장하고 , Replace("공백")으로 바꾸고
         *  1-2. 없다면 넘어감
         * 2. 다 돌았을때 걸리는 크기가 원래 문자열과 동일하다면 answer++;
         * 3. 마지막으로 answer 리턴
         */
        string[] str = { "aya", "ye", "woo", "ma" };
        int cnt = 0;
        int answer = 0;

        for (int i=0;i<babbling.Length;i++)
        {
            cnt = 0;

            for (int j = 0;j<str.Length;j++)
            {
                if (babbling[i].Contains(str[j]))
                {
                    //그 부분을 Replace() 로 지워버리기
                    babbling[i] = babbling[i].Replace(str[j], "1");
                }
            }

            foreach (char c in babbling[i])
            {
                if (c != '1')
                {
                    cnt++;
                }
            }

            if (cnt == 0)
            {
                answer++;
            }
        }

        return answer;
    }
}