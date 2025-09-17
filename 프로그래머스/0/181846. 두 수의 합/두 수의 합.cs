using System;
using System.Linq;

public class Solution
{
    public string solution(string a, string b)
    {
        //전가산기 로직, 문자열로 더한다.
        //1. 주어진 문자열을 모두 reverse한다.
        //2. 반복문 사용 for vs while ? => for
        //3. a와 b중 누가 더 긴 문자열인가? 판별하는 거 먼저
        //3. 그럼 첫번째 인덱스가 일의 자리가 된것이므로 2개를 더하고 올림수는 따로 빼놓는다.

        string answer = "";
        string letters = "";
        int adder = 0;
        string strA = string.Concat(a.Reverse());
        string strB = string.Concat(b.Reverse());
        string longerStr = strA.Length > strB.Length ? strA : strA.Length < strB.Length ? strB : strA;
        string smallerStr = strA.Length > strB.Length ? strB : strA.Length < strB.Length ? strA : strB;

        //더 긴 string의 크기만큼 for문을 사용
        //*****만약? 더 짧은 string이 먼저 끝나버리면?***** => 읽었을때의 값을 0으로 만들어버린다. 
        for (int i = 0; i < longerStr.Length; i++)
        {
            if (i < smallerStr.Length)
            {
                int num = int.Parse(longerStr[i].ToString()) + int.Parse(smallerStr[i].ToString()) + adder;

                //올림수가 나오면
                if (num > 9)
                {
                    adder = num / 10;
                    int c = num % 10;
                    letters += c.ToString();
                }
                //올림수가 없으면?
                else
                {
                    letters += num.ToString();
                    adder = 0;
                }
            }
            else
            {
                int num = int.Parse(longerStr[i].ToString()) + adder;

                //올림수가 나오면
                if (num > 9)
                {
                    adder = num / 10;
                    int c = num % 10;
                    letters += c.ToString();
                }
                //올림수가 없으면?
                else
                {
                    letters += num.ToString();
                    adder = 0;
                }
            }
        }

        //올림수가 남아있는지 확인
        if (adder != 0)
        {
            letters += "1";
            answer += string.Concat(letters.Reverse());
        }
        else
        {
            answer += string.Concat(letters.Reverse());
        }
        return answer;
    }
}