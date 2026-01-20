public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int arrLength1 = arr1.GetLength(0);
        int arrLength2 = arr1.GetLength(1);
        int[,] answer = new int[arrLength1, arrLength2];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                int num1 = arr1[i, j];
                int num2 = arr2[i, j];

                answer[i, j] = num1 + num2;
            }
        }
        return answer;
    }
}