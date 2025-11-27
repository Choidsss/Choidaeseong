using System;

public class Solution
{
    public int solution(int n)
    {
        int curseThree = 1;
        int cnt = 0;

        while (cnt < n)
        {
            string str = curseThree.ToString();

            if (curseThree % 3 == 0 && curseThree != 1 && curseThree != 2)
            {
                curseThree++;
            }
            else if (str.Contains("3"))
            {
                curseThree++;
            }
            else
            {
                curseThree++;
                cnt++;
            }
        }
        curseThree = curseThree - 1;

        string check = curseThree.ToString();

        if (curseThree % 3 == 0)
        {
            curseThree++;
        }
        else if (check.Contains("3"))
        {
            curseThree++;
        }
        return curseThree;
    }
}