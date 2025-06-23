using System;

public class Solution
{
    public string solution(string str1, string str2)
    {
        int index1 = 0;
        int index2 = 0;
        bool _isStr1 = true;
        bool _isStr2 = false;
        string answer = "";
        
        while (index1 < str1.Length || index2 < str2.Length)
        {
            if (_isStr1)
            {
                answer += str1[index1++];
                _isStr1 = false;
                _isStr2 = true;
            }
            else if (_isStr2)
            {
                answer += str2[index2++];
                _isStr2 = false;
                _isStr1 = true;
            }
        }
        return answer;
    }
}