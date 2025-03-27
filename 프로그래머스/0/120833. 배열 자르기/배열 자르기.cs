using System;

 public class Solution
 {
     public int[] solution(int[] numbers, int num1, int num2)
     {
        int[] answer = new int[num2 - num1 + 1];

        Array.Copy(numbers, num1, answer, 0, answer.Length);

        //for(int i = num1; i < num2; i++)
        //{
        //    answer[i - num1] = numbers[i];
        //}
        return answer;
     }
 }