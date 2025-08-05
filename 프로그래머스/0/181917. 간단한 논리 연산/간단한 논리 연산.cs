using System;

public class Solution
{
    public bool solution(bool x1, bool x2, bool x3, bool x4)
    {
        bool answer = true;

        if ((x1 || x2 == true) && (x3 || x4 == true))
        {
            return answer = true;
        }
        else if ((x1 || x2 == false) && (x3 || x4 == true))
        {
            return answer = false;
        }
        else if ((x1 || x2 == true) && (x3 || x4 == false))
        {
            return answer = false;
        }
        else
        {
            return answer = false;
        }
    }
}