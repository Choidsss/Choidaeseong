using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        string answer = "";
        List<string> card1List = cards1.ToList();
        List<string> card2List = cards2.ToList();

        for (int i = 0;i<goal.Length;i++)
        {
            if (card1List.Count > 0 && goal[i] == card1List[0])
            {
                card1List.RemoveAt(0);
            }
            else if (card2List.Count > 0 && goal[i] == card2List[0])
            {
                card2List.RemoveAt(0);
            }
            else
            {
                answer = "No";
                break;
            }
        }

        if (answer == "No") 
        {
            return answer;
        } 
        else 
        { 
            answer = "Yes";
            
            return answer;
        }
    }
}