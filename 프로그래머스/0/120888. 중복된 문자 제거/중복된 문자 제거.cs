using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";

        //계속 집어넣다가 앞에꺼랑 같으면 continue시키기
        for (int i=0;i<my_string.Length;i++)
        {
            if (answer.Contains(my_string[i]))
            {
                continue;
            }
            else
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}