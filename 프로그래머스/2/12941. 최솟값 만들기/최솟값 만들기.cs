using System;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        int indexA = 0;
        int indexB = 0;
        int lastIndexA = 1;
        int lastIndexB = 1;

        Array.Sort(A);
        Array.Sort(B);

        for(int i = 0; i < A.Length; i++)
        {
            if (i == A.Length-1)
            {
                answer += A[indexA] * B[indexB];
                break;
            }

            if (A[indexA] == Math.Min(A[indexA], B[indexB]))
            {
                answer += A[indexA] * B[B.Length - lastIndexB];
                indexA++;
                lastIndexB++;
            }
            else
            {
                answer += B[indexB] * A[A.Length - lastIndexA];
                indexB++;
                lastIndexA++;
            }
        }

        return answer;
    }
}