using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];
        int storedIndex = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>();

        for (int i=0;i<s.Length;i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic.TryGetValue(s[i], out int value);
                answer[i] = i - value;
                dic[s[i]] = i;
            }
            else
            {
                dic.Add(s[i], i);
                answer[i] = -1;
            }
        }
        return answer;
    }
}