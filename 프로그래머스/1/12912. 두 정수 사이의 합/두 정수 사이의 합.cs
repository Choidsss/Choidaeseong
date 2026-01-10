public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;
        int smaller = a > b ? b : a < b ? a : a; 
        int bigger = a > b ? a : a < b ? b : a; 

        for (long i = smaller; i <= bigger; i++)
        {
            answer += i;
        }
        return answer;
    }
}