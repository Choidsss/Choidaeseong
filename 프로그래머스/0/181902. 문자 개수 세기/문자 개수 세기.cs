using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string my_string)
    {
        List<int> ans = new List<int>();
        int[] answer = new int[] { };

        for (int i = 'A'; i <= 'Z'; i++)
        {
            int cnt = my_string.Count((x) => x == i);
            ans.Add(cnt);
        }
        for (int i = 'a'; i <= 'z'; i++)
        {
            int cnt = my_string.Count((x) => x == i);
            ans.Add(cnt);
        }
        answer = ans.ToArray();
        return answer;
    }
}