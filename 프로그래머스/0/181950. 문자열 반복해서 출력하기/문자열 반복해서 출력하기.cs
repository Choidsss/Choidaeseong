using System;

public class Example
{
    static void Main(string[] args)
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');//0번에 있는 문자열(0) '공백' 1번에 있는 숫자(1)

        String s1 = input[0];//반복시킬 문자열을 s1에 저장
        int a = Int32.Parse(input[1]);// 몇번 반복을 시킬건지

        for(int i=1;i<=a;i++)//반복시키는 코드
        {
            Console.Write(s1);
        }

    }
}