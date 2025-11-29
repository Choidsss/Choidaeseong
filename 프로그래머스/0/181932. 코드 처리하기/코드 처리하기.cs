using System;

public class Solution
{
    public string solution(string code)
    {
        string answer = "";
        bool mode = false;

        for (int i = 0;i < code.Length; i++)
        {
            if (mode)
            {
                if (code[i] == '1')
                {
                    mode = false;
                    continue;
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        answer += code[i];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                if (code[i] == '1')
                {
                    mode = true;
                    continue;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        answer += code[i];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        
        if (answer == "")
        {
           answer = "EMPTY";
        }
        return answer;
    }
}