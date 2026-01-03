public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int cnt = 1;

        while (cnt <= n)
        {
            if (n % cnt == 0)
            {
                answer += cnt;
                cnt++;
            }
            else
            {
                cnt++;
            }
        }
        return answer;
    }
}