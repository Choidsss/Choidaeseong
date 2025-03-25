using System;

 public class Solution
 {
     public string solution(string my_string)
     {
         string answer = "";
         char[] str = my_string.ToCharArray();
         Array.Reverse(str);

         for(int i=0;i<str.Length;i++)
         {
             answer += str[i];
         }
         return answer;
     }
 }