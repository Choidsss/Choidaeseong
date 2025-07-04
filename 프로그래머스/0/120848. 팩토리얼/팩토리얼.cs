using System;

public class Solution {
    public int solution(int n)
{
    int answer = 0;
    int factorial = 1;
    int number = 1;

    while (factorial <= n)
    {
        factorial = factorial * number;
        number++;
    }
    answer = number-2;
    return answer;
}
}