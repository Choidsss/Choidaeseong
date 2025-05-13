using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        string odd = "";
        string even = "";

        for (int i=0;i<num_list.Length;i++)
        {
            if (num_list[i]%2==0)
            {
                even += num_list[i].ToString();
            }
            else
            {
                odd += num_list[i].ToString();
            }
        }
        int answer = int.Parse(even)+ int.Parse(odd);
        return answer;
    }
}