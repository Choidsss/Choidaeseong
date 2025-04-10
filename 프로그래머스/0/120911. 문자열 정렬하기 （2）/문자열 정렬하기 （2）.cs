using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer= "";
        string alpha = "";
        char[] str = new char[my_string.Length]; 

        foreach (char c in my_string)
        {
            if (char.IsUpper(c))
            {
                alpha += char.ToLower(c);
            }
            else
            {
                alpha += c;
            }
        }
        str = alpha.ToCharArray();
        Array.Sort(str);
        answer = new string(str);
        return answer;
    }
}