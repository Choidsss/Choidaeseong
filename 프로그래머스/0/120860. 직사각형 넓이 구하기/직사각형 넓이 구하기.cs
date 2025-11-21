using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int answer = 0;
        int[] xArr = new int[4];
        int[] yArr = new int[4];
        int lenX = 0;
        int lenY = 0;

        for (int i=0;i<dots.GetLength(0);i++)
        {
            int x = dots[i, 0];
            int y = dots[i, 1];
            xArr[i] = x;
            yArr[i] = y;
        }

        for (int i = 0; i < xArr.Length; i++)
        {
            if (xArr[0] == xArr[i] && i != 0)
            {
                lenY = yArr[i] - yArr[0]; 
            }
            if (yArr[0] == yArr[i] && i != 0)
            {
                lenX = xArr[i] - xArr[0];
            }
        }
        answer = Math.Abs(lenX) * Math.Abs(lenY);
        return answer;
    }
}