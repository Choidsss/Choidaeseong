using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int answer = 0;
        int idx1 = 0;
        int idx2 = 0;
        int numArrSize = sizes.GetLength(0) * 2;
        int[] biggerArr = new int[numArrSize/2];
        int[] smallerArr = new int[numArrSize/2];

        for (int i=0;i<sizes.GetLength(0);i++)
        {
            int a = sizes[i, 0];
            int b = sizes[i, 1];

            if (a > b)
            {
                biggerArr[idx1++] = a;
                smallerArr[idx2++] = b;
            }
            else if (b > a)
            {
                biggerArr[idx1++] = b;
                smallerArr[idx2++] = a;
            }
            else
            {
                biggerArr[idx1++] = b;
                smallerArr[idx2++] = a;
            }
        }
        Array.Sort(biggerArr);
        Array.Sort(smallerArr);

        int w = biggerArr[biggerArr.Length-1];
        int h = smallerArr[smallerArr.Length-1];

        answer = w * h;
        return answer;
    }
}