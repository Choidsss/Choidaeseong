using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string[] strArr)
    {
         Dictionary<int, int> lengthCounts = new Dictionary<int, int>();

 foreach (string str in strArr)
 {
     int length = str.Length;
     if (lengthCounts.ContainsKey(length))
     {
         lengthCounts[length]++;
     }
     else
     {
         lengthCounts[length] = 1;
     }
 }

 return lengthCounts.Values.Max();
    }
}