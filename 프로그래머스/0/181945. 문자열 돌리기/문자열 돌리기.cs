using System;

public class Example
{
     public static void Main()
 {
     String s;

     Console.Clear();
     s = Console.ReadLine();//입력값을 s에 저장

     //문자열 하나하나떼서 한줄씩 출력

     for(int i=0;i<s.Length;i++)
     {
         Console.WriteLine(s[i]);
     }
     
 }
}