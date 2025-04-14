using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer=0;

        Array.Sort(numbers);

        answer = numbers[numbers.Length - 1] * numbers[numbers.Length-2];
        if (answer < numbers[0] * numbers[1])
        {
            answer = numbers[0] * numbers[1];
        }
        return answer;
    }
}