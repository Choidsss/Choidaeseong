using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        /*
         * 둘만의 암호 *(순서좀 잘 짜보자)*
         * 
         * 뭐부터 할래?
         * 1. 반복문으로 하나씩 빼내
         * 2. ++시켜야 되는데 어디에서 시킬거야? => while문 안에서
         * 3. 그러고 조건을 확인 해 => 어떤 조건들인데? = 1. z를 넘어갔어? 2. skip이랑 겹쳐?
         * 4. 어떤 조건부터 확인을 시켜야 맞을까?
         *
         * ++시킨 다음에 z가 될 수도 있는거고
         * ++시키고 skip이 되고 z가 될수도 있는건데
         * 
         * 그럼 스킵조건을 먼저 보는게 맞을거 같은데
         */
        string answer = "";

        for (int i = 0;i<s.Length;i++)
        {
            char alpha = s[i];
            int cnt = 0;

            //z 에 걸리면 a로 돌아오는 조건은 어디에 달려야 하지????
            //알파벳만 바꿔주면 되잖아, 그러면 알파 바로 밑에 걸려야 되는거 아니야?
            //어차피 카운팅 세는건 밑에 해놨으니까
            while (cnt < index)
            {
                alpha++; // 일단 갔어

                if (alpha == '{')
                {
                    alpha = 'a';
                }

                if (skip.Contains(alpha.ToString())) // 걸렸니?
                {
                    continue;   //넘어가는데 카운팅은 안할거야 (처음부터 알파벳을 ++시키니까, continue)
                }
                else
                {
                    //안걸렸으면 카운팅 시켜
                    cnt++;    
                }
            }
            answer += alpha.ToString();
        }
        return answer;
    }
}