using System;

public class Solution
{
    public int solution(int[,] board)
    {
        int row = board.GetLength(0);
        int col = board.GetLength(1);
        int answer = 0;
        int[,] copyArr = new int[row, col];

        int[] deltaR = {-1,-1,-1,0,0,1,1,1};
        int[] deltaC = {-1,0,1,-1,1,-1,0,1}; 

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (board[i,j] != 0)
                {
                    copyArr[i, j] = 1;
                    
                    for (int k = 0;k < 8;k++)
                    {
                        int dx = i + deltaR[k];
                        int dy = j + deltaC[k];

                        if (dx >= 0 && dx < row && dy >= 0 && dy < col)
                        {
                            copyArr[dx, dy] = 1;
                        }
                    }

                }
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (copyArr[i, j] != 1)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}