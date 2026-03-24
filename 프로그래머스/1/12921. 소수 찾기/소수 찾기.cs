public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        bool[] PrimeArr = new bool[n + 1];
        PrimeArr[0] = false;
        PrimeArr[1] = false;

        for (int i = 2;i<=n;i++)
        {
            PrimeArr[i] = true;
        }


        for (int i=2;i<=n;i++)
        {
            if (PrimeArr[i] == false)
            {
                continue;
            }

            answer++;

            for (int j= i * 2;j<=n;j += i)
            {
                PrimeArr[j] = false;
            }

        }

        return answer;
    }
}