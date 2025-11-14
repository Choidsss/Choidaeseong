using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        string answer = "";
        string[] strArr = new string[my_string.Length];

        for (int i = 0; i < my_string.Length; i++)
        {
            strArr[i] += my_string[i];
        }

        for (int i=0;i<queries.GetLength(0);i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            Array.Reverse(strArr, s, e - s + 1);
        }

        for (int i = 0; i < strArr.Length; i++)
        {
            answer += strArr[i];
        }
        return answer;
    }
}