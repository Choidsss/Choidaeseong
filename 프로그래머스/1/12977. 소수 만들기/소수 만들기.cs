using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for (int i=0;i<nums.Length-2;i++)
        {
            for (int j = i+1; j < nums.Length-1; j++)
            {
                for (int k = j+1; k < nums.Length; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    bool dev = false;

                    for (int n = 2;n<sum/2;n++)
                    {
                        if (sum%n == 0)
                        {
                            dev = true;
                            break;
                        }
                    }

                    if (dev)
                    {
                        continue;
                    }
                    else
                    {
                        answer++;
                    }
                }
            }
        }

        return answer;
    }
}