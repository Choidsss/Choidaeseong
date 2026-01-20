using System.Linq;
using System.Collections;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string upperStr = "";

        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                upperStr += c.ToString();
            }
            else
            {
                answer += c.ToString();
            }
        }
        char[] sortedUpper = new char[upperStr.Length];
        char[] sortedLower = new char[answer.Length];

        sortedLower = answer.OrderByDescending((x) => x).ToArray();
        sortedUpper = upperStr.OrderByDescending((x) => x).ToArray();
        
        return new string(sortedLower) + new string(sortedUpper);
    }
}