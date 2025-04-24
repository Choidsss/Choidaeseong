using System;

public class Solution
{
    public string solution(string my_string, int num1, int num2)
    {
        char[] copyArr = new char[] { };
        char swapLetter;
        string answer;

        copyArr = my_string.ToCharArray();
        swapLetter = copyArr[num1];
        copyArr[num1] = copyArr[num2];
        copyArr[num2] = swapLetter;

        answer = new string(copyArr);
        return answer;
    }
}  