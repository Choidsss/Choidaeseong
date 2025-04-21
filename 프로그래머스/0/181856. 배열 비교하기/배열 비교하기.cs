using System;

public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int t1 = 0;
        int t2 = 0;
        //arr1의 합
        for (int i=0;i<arr1.Length;i++)
        {
            t1 += arr1[i];
        }
        
        //arr2의 합
        for (int j=0;j<arr2.Length;j++)
        {
            t2 += arr2[j];
        }
        int answer = arr1.Length > arr2.Length ? 1 :
                     arr2.Length > arr1.Length ? -1 :
                     arr1.Length == arr2.Length && t1 > t2 ? 1 :
                     arr1.Length == arr2.Length && t2 > t1 ? -1 :
                     0;
        return answer;
    }
}