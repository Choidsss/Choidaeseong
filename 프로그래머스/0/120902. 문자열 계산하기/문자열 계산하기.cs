using System;

public class Solution
{
    public int solution(string my_string)
    {
        string[] str = new string[] { };

        str = my_string.Split(' ');
        int result = 0;
        bool flag = true;


        for (int i = 0;i<str.Length;i++)
        {

            if (i % 2 == 0)
            {
                if (flag == true)
                {
                    result += int.Parse(str[i]);
                }
                else
                {
                    result -= int.Parse(str[i]);
                }
            }
            else
            {
                if (str[i] == "+")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
        }
        return result;
    }
}