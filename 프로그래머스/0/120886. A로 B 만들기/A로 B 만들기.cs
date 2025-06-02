using System;

public class Solution
{
    public int solution(string before, string after)
    {
        int answer = 0;
        int cnt = 0;
        char[] beforeArr = before.ToCharArray();
        char[] afterArr = after.ToCharArray();
        
        Array.Sort(beforeArr);
        Array.Sort(afterArr);

        for(int i = 0; i < beforeArr.Length; i++)
        {
            if (beforeArr[i] == afterArr[i] && before.Length==after.Length)
            {
                cnt++;
            }
            else
                continue;
        }

        if (cnt == afterArr.Length)
        {
            answer = 1;
        }
        else
            answer = 0;
            return answer;
    }
}