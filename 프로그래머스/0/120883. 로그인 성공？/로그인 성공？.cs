using System;

public class Solution
{
    public string solution(string[] id_pw, string[,] db)
    {
        string answer = "";
        bool isId = false;

        for (int i=0;i<db.GetLength(0);i++)
        {
            string id = db[i, 0];
            string pw = db[i, 1];

            if (id_pw[0].Equals(id) && id_pw[1].Equals(pw))
            {
                answer += "login";
                break;
            }

            if (id_pw[0].Equals(id))
            {
                isId = true;
            }
        }
        
        if (answer != "")
        {
            return answer;
        }
        else
        {
            if(isId)
            {
                return answer += "wrong pw";
            }
            else
            {
                return answer += "fail";
            }
        }

    }
}