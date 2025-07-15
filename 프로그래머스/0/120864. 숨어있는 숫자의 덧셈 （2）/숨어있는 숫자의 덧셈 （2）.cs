using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string my_string)
    {
        string temp = "";
        int answer = 0;
        List<int> nums = new List<int>();

        foreach (char c in my_string)
        {
            if (char.IsDigit(c))
            {
                temp += c;
            }
            else
            {
                if (temp.Length > 0)
                {
                    nums.Add(int.Parse(temp));
                    temp = "";
                }
            }
        }

        for (int i=0;i<nums.Count;i++)
        {
            answer += nums[i];
        }
        
        
        if (temp.Length > 0)
        {
            answer += int.Parse(temp);
        }

        return answer;
    }
}