using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int lux = 51;
        int luy = 51;
        int rdx = 0;
        int rdy = 0;
        int[] answer = new int[4];

        for (int i = 0; i < wallpaper.Length; i++)
        {
            string str = wallpaper[i];
            int cnt = 0;

            foreach (char c in str)
            {
                //지금 인덱스에 '#'이 있다면
                if (c == '#')
                {
                    //각 변수값과, 인덱스 값 비교, Min, Max값 비교
                    lux = Math.Min(lux, cnt);
                    luy = Math.Min(luy, i); //y는 인덱스를 넣는게 아니라 i값을 넣음
                    rdx = Math.Max(rdx, cnt);
                    rdy = Math.Max(rdy, i);
                    cnt++;
                }
                else
                {
                    cnt++;
                }
            }
        }
        answer[0] = luy;
        answer[1] = lux;
        answer[2] = rdy + 1;
        answer[3] = rdx + 1;
        return answer;
    }
}