using System;

public class Solution
{
    public string solution(int age)
    {
        string answer = "";
        string alpha = "abcdefghij";
        string number = age.ToString();

        foreach (char c in number)
        {
           for (int i = 0;i<alpha.Length;i++)
           {
              if (i==int.Parse(c.ToString()))
              {
                    answer += alpha[i];
              }
           }
        }
        return answer;
    }
}