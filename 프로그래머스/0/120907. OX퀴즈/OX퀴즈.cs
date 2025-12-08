using System;

public class Solution
{
    public string[] solution(string[] quiz)
    {
        string[] answer = new string[quiz.Length];

        for (int i = 0; i < quiz.Length; i++)
        {
            string[] str = new string[quiz.Length];
            str = quiz[i].Split(' ');
            string op = str[1];
            int num = 0;

            switch (op)
            {
                case "+":
                    num = int.Parse(str[0]) + int.Parse(str[2]);
                    break;

                case "-":
                    num = int.Parse(str[0]) - int.Parse(str[2]);
                    break;
            }

            if (num == int.Parse(str[4]))
            {
                answer[i] = "O";
            }
            else
            {
                answer[i] = "X";
            }
        }
        return answer;
    }
}