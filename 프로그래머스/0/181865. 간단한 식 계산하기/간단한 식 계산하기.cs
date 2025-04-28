using System;

public class Solution
{
    public int solution(string binomial)
    {
        string[] numbers = new string[3];
        int answer = 0;

        numbers = binomial.Split(' ');

        if (numbers[1]=="+")
        {
            answer = Int32.Parse(numbers[0]) + Int32.Parse(numbers[2]);
        }
        else if (numbers[1] == "-")
        {
            answer = Int32.Parse(numbers[0]) - Int32.Parse(numbers[2]);
        }
        else if (numbers[1] == "*")
        {
            answer = Int32.Parse(numbers[0]) * Int32.Parse(numbers[2]);
        }
            return answer;

    }
}