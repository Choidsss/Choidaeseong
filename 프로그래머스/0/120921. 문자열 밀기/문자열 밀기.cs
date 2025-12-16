using System;
using System.Linq;

public class Solution
{
    public int solution(string A, string B)
    {
        string check = B;
        int answer = 0;
        int cnt = 0;
        bool flag = true;

        //문자열 B를 2개를 이어 붙여서 A가 포함되는지에 대한 여부 확인
        for (int i = 0; i < B.Length; i++)
        {
            check += B[i];
        }

        if (A.Length == B.Length && A.Equals(B))
        {
            answer = 0;
        }
        else
        {
            if (check.Contains(A))
            {
                while (flag)
                {
                    string s = A[A.Length - 1].ToString();
                    A = A.Remove(A.Length - 1, 1);
                    A = A.Insert(0, s);
                    cnt++;

                    if (B.Equals(A))
                    {
                        flag = false;
                        answer = cnt;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
            else
            {
                answer = -1;
            }
        }
        
        return answer;
    }
}