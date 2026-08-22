using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];

        while (!s.Equals("1"))
        {
            answer[0]++;
            int changeToBinary = s.Count<char>((x) => x == '1');
            answer[1] += s.Length - changeToBinary;

            s = Convert.ToString(changeToBinary, 2);
        }
        return answer;
    }
}