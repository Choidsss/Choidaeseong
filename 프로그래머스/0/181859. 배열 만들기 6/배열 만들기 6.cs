using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> nums = new List<int>();
        int[] stk = new int[] { };

        for (int i=0;i<arr.Length;i++)
        {
            if (nums.Count > 0)
            {
                if (nums.Last() == arr[i])
                {
                    nums.RemoveAt(nums.Count-1);
                }
                else
                {
                    nums.Add(arr[i]);
                }
            }
            else
            {
                nums.Add(arr[i]);
            }
        }

        stk = nums.ToArray();

        if (stk.Length != 0)
        {
            return stk;
        }
        else
        {
            return new int[]{ -1};
        }
    }
}