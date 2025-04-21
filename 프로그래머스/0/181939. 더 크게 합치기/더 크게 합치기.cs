using System;

public class Solution
{
    public int solution(int a, int b)
    {
        string str="";
        string num1 = a.ToString();
        string num2 = b.ToString();
        int answer = 0;


        if (Convert.ToInt32(num1+num2)> Convert.ToInt32(num2+num1))
        {
            answer = Convert.ToInt32(num1+num2);
        }
        else if (Convert.ToInt32(num2+num1)> Convert.ToInt32(num1+num2))
        {
            answer = Convert.ToInt32(num2 + num1);
        }
        else
        {
            answer = Convert.ToInt32(num1 + num2);
        }
            return answer;
    }
}