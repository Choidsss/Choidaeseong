using System;

public class Solution
{
    public int solution(int n, int w, int num)
    {
        int answer = 1;
        int cnt = 0;
        bool stop = false;
        int totalLine = n % w == 0 ? (n / w) : (n / w) + 1;
        int[,] arr = new int[totalLine, w];
        int[] numCoordinate = new int[2];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = -1;
            }
        }

        for (int i = 0; i < totalLine; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < w; j++)
                {
                    arr[i, j] = cnt++;
                    if (cnt == n) { break; }

                    if (cnt == num) { numCoordinate[0] = i; numCoordinate[1] = j; }
                }
            }
            else
            {
                for (int j = w - 1; j >= 0; j--)
                {
                    arr[i, j] = cnt++;
                    if (cnt == n) { break; }

                    if (cnt == num) { numCoordinate[0] = i; numCoordinate[1] = j; }
                }
            }
        }

        while (!stop)
        {
            num += w * 2;
            numCoordinate[0] += 2;

            if (num > n) { stop = true; }
            else { answer += 2; }
        }

        num = num - (w * 2);
        numCoordinate[0] -= 2;
        numCoordinate[0]++;

        if (numCoordinate[0] < totalLine && arr[numCoordinate[0], numCoordinate[1]] != -1)
        {
            answer++;
        }

        return answer;
    }
}