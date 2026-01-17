public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        int[] index = new int[2];

        if (s.Length % 2 == 0)
        {
            index[0] = s.Length / 2;
            index[1] = s.Length / 2 + 1;
            answer += s[index[0] - 1].ToString();
            answer += s[index[1] - 1].ToString();
        }
        else
        {
            answer = s[s.Length / 2].ToString();
        }
        return answer;
    }
}