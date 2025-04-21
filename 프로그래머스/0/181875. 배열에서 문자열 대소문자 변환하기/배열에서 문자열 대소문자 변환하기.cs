using System;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        string[] answer = new string[strArr.Length];

        for (int i=0;i<strArr.Length;i++)
        {
            //1,3,5 홀수일때
            if (i%2==0)
            {
                foreach (char c in strArr[i])
                {
                    answer[i] += char.ToLower(c);
                }
            }
            else
            {
                foreach (char c in strArr[i])
                {
                    answer[i] += char.ToUpper(c);
                }
            }
        }
        return answer;
    }
}