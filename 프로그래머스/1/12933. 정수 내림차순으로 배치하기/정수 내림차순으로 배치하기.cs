using System;

public class Solution
{
    public long solution(long n)
    {
        long answer = 0;
        string str = n.ToString();
        string numStr = "";
        string[] numStrArr = new string[str.Length];

        for (int i = 0;i < str.Length; i++)
        {
            numStrArr[i] = str[i].ToString();
        }

        Array.Sort(numStrArr);
        Array.Reverse(numStrArr);
        
        for (int i = 0; i < numStrArr.Length; i++)
        {
            numStr += numStrArr[i];
        }
        answer = long.Parse(numStr);
        return answer;
    }
}