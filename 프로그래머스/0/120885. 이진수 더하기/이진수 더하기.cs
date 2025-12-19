using System;

public class Solution
{
    public string solution(string bin1, string bin2)
    {
        string answer = "";
        int round = 0;
        string str = "";
        int check = 0;
        int len1 = bin1.Length;
        int len2 = bin2.Length;

        if (len1 > len2)
        {
            bin2 = bin2.PadLeft(len1, '0');
        }
        else if (len2 > len1)
        {
            bin1 = bin1.PadLeft(len2, '0');
        }

        int len = bin1.Length;

        for (int i = len - 1; i >= 0; i--)
        {
            int a = int.Parse(bin1[i].ToString());
            int b = int.Parse(bin2[i].ToString());

            //올림수 없음
            if (round == 0)
            {
                int num1 = a + b;

                if (num1 == 2)
                {
                    round = 1;
                    num1 = 0;
                }
                else
                {
                    round = 0;
                }

                str += num1.ToString();
            }
            //올림수 있음
            else
            {
                int num2 = a + b;
                num2 += round;

                if (num2 >= 2)
                {
                    round = 1;

                    if (num2 == 2)
                    {
                        num2 = 0;
                    }
                    else if (num2 == 3)
                    {
                        num2 = 1;
                    }
                }
                else
                {
                    round = 0;
                }

                str += num2.ToString();
            }
        }

        if (round == 1)
        {
            str += "1";
        }

        for (int i = str.Length - 1; i >= 0; i--)
        {
            answer += str[i];
        }
        return answer;
    }
}