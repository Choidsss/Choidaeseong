using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public string solution(string polynomial)
    {
        string answer = "";
        int num1 = 0;
        int num2 = 0;

        string[] str = polynomial.Split();

        for (int i=0;i<str.Length;i++)
        {
            if (str[i] == "+")
            {
                continue;
            }
            else if (str[i].Contains("x"))
            {
                string numstr = "";

                foreach (char c in str[i])
                {
                    if (c != 'x')
                    {
                        numstr += c.ToString();
                    }
                    else
                    {
                        // 만약 x + 3이 정답이라 가정하면?
                        if (numstr == "" || numstr == null)
                        {
                            num1 += 1;
                        }
                        else
                        {
                            num1 += int.Parse(numstr);
                        }
                    }
                }
            }
            else
            {
                num2 += int.Parse(str[i]);
            }
        }

        if (num2 == 0)
        {
            if (num1 == 0)
            {
                answer += "";
            }
            else if (num1 == 1)
            {
                answer += "x";
            }
            else
            {
                answer += num1.ToString();
                answer += "x";
            }
        }
        else
        {
            if (num1 == 0)
            {
                answer += num2.ToString();
            }
            else if (num1 == 1)
            {
                answer += "x";
                answer += " ";
                answer += "+";
                answer += " ";
                answer += num2.ToString();
            }
            else
            {
                answer += num1.ToString();
                answer += "x";
                answer += " ";
                answer += "+";
                answer += " ";
                answer += num2.ToString();
            }
        }

        return answer;
    }
}