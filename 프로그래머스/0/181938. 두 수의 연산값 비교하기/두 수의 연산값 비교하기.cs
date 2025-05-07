using System;

public class Solution
{
    public int solution(int a, int b)
    {
        string str = "";
        str += a.ToString();
        str += b.ToString();
        int answer = Int32.Parse(str) > 2 * a * b ? Int32.Parse(str):
                     Int32.Parse(str) < 2 * a * b ? 2 * a * b:
                     Int32.Parse(str);

        return answer;
    }
}