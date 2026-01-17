public class Solution
{
    public int solution(long num)
    {
        int answer = 0;
        int cnt = 0;

        while (cnt <= 500)
        {
            if (num == 1) 
            {
                answer = cnt;
                break;
            } 

            if (num % 2 == 0)
            {
                num = num / 2;
                cnt++;
            }
            else
            {
                num = num * 3 + 1;
                cnt++;
            }
        }

        if (num != 1) answer = -1;

        return answer;
    }
}