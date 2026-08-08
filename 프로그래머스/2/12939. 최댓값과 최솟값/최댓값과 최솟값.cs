using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string[] alphas = s.Split(' ');
        int[] nums = new int[alphas.Length];

        for (int i=0;i<alphas.Length;i++)
        {
            string a = alphas[i].ToString();
            nums[i] = int.Parse(a);
        }
        Array.Sort(nums);

        answer += nums[0];
        answer += " ";
        answer += nums[nums.Length-1];

        return answer;
    }
}