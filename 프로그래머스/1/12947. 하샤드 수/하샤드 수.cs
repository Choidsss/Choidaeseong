public class Solution
{
    public bool solution(int x)
    {
        bool answer = false;
        int addNum = 0;
        string str = x.ToString();

        foreach(char c in str)
        {
            addNum += int.Parse(c.ToString());
        }

        if (x % addNum != 0) answer = false;
        else answer = true;

        return answer;
    }
}