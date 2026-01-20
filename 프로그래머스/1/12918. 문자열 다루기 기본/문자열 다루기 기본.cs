public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;

        if(s.Length == 4 || s.Length == 6)
        {
            foreach(char c in s)
            {
                if (char.IsDigit(c))
                {
                    continue;
                }
                else
                {
                    answer = false;
                }
            }
        }
        else
        {
            answer = false;
        }
        return answer;
    }
}