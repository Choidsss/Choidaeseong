using System;

public class Solution
{
    public string solution(string myString)
    {
        string answer = "";

        foreach (char c in myString)
        {
            if (c=='a'||c=='A')
            {
                answer += char.ToUpper(c);
            }
            else
            {
                answer += char.ToLower(c);
            }
        }
        return answer;
    }
}