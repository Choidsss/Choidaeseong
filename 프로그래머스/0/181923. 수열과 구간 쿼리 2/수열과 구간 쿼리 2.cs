using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        List<int> answerList = new List<int>();
        int[] answer = new int[] { };

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];

            List<int> nums = new List<int>();

            for (int j = s; j <= e; j++)
            {
                if (arr[j] > k)
                {
                    nums.Add(arr[j]);
                }
            }

            if (nums.Count > 0)
            {
                nums.Sort();
                answerList.Add(nums[0]);
            }
            else 
            {
                answerList.Add(-1);
            }
        }
        answer = answerList.ToArray();
        return answer;
    }
}