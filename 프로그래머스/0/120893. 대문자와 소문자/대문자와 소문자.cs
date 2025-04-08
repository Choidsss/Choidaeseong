using System;

public class Solution {
    public string solution(string my_string)
{
    string answer = "";

    foreach (char c in my_string)
    {
        if (char.IsUpper(c))
        {
            answer += char.ToLower(c);
        }
        else if(char.IsLower(c))
        {
            answer += char.ToUpper(c);
        }
    }
    return answer;
}
}