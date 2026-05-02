public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];
        int BigNum = n >= m ? n : m;
        int SmallNum = n <= m ? n : m;
        int temp = 1;

        if (BigNum % SmallNum == 0)
        {
            answer[0] = SmallNum;
            answer[1] = BigNum;
        }
        else
        {
            while (temp > 0)
            {
                temp = BigNum % SmallNum;
                BigNum = SmallNum;
                SmallNum = temp;
            }
            answer[0] = BigNum;
            answer[1] = n * m / BigNum;
        }
        return answer;
    }
}