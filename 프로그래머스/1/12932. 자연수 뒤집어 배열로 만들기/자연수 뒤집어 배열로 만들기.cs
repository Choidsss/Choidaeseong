public class Solution
{
    public int[] solution(long n)
    {
        string str = n.ToString();
        int num = 1;
        int[] answer = new int[str.Length];

        for (int i=0;i<str.Length;i++)
        {
            answer[i] = int.Parse(str[str.Length - num].ToString());
            num++;
        }
        return answer;
    }
}