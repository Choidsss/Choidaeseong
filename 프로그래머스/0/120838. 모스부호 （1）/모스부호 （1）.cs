using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string letter)
    {
        Dictionary<string, string> morse = new Dictionary<string, string>();
        string answer = "";
        string[] str = letter.Split(' ');

        morse.Add(".-", "a");
        morse.Add("-...", "b");
        morse.Add("-.-.", "c");
        morse.Add("-..", "d");
        morse.Add(".", "e");
        morse.Add("..-.", "f");
        morse.Add("--.", "g");
        morse.Add("....", "h");
        morse.Add("..", "i");
        morse.Add(".---", "j");
        morse.Add("-.-", "k");
        morse.Add(".-..", "l");
        morse.Add("--", "m");
        morse.Add("-.", "n");
        morse.Add("---", "o");
        morse.Add(".--.", "p");
        morse.Add("--.-", "q");
        morse.Add(".-.", "r");
        morse.Add("...", "s");
        morse.Add("-", "t");
        morse.Add("..-", "u");
        morse.Add("...-", "v");
        morse.Add(".--", "w");
        morse.Add("-..-", "x");
        morse.Add("-.--", "y");
        morse.Add("--..", "z");

        for (int i=0;i<str.Length;i++)
        {
           if (morse.TryGetValue(str[i], out string value))
           {
               answer += value;
           }

        }
        return answer;
    }
}