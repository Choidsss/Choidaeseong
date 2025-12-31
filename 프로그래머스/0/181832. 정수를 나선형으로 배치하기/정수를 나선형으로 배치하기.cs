using System;

public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];
        int cnt = 1;
        int top = 0;
        int bottom = n-1;
        int left = 0;
        int right = n-1;

        while (cnt <= n*n)
        {
            // 방향 : 우
            for (int i=left;i<= right;i++)
            {
                answer[top, i] = cnt++;
            }
            top++;
            // 방향 : 하
            for (int i = top; i <= bottom; i++)
            {
                answer[i , right] = cnt++;
            }
            right--;
            // 방향 : 좌
            for (int i = right; i >= left; i--)
            {
                answer[bottom, i] = cnt++;
            }
            bottom--;
            // 방향 : 상
            for (int i = bottom; i >= top; i--)
            {
                answer[i, left] = cnt++;
            }
            left++;
        }
        return answer;
    }
}