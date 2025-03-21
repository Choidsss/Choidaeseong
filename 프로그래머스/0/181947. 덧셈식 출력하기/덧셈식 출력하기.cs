using System;

public class Example
{
      public static void Main()
   {
       String[] s;

       Console.Clear();
       s = Console.ReadLine().Split(' ');

       int a = Int32.Parse(s[0]);//a값 작성
       int b = Int32.Parse(s[1]);//b값 작성

     int c;
 c = a + b;

 Console.WriteLine("{0}", $"{a} + {b} = {c}");
   }
}