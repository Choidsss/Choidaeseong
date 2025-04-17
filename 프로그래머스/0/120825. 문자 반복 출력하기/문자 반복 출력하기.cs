using System;

public class Solution
{
     public string solution(string my_string, int n)
 {
     string answer = "";
    
        foreach(char str in my_string)
     {
         answer += new string(str, n);
     }
     return answer;
 }
}