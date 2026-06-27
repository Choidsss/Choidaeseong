using System;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        int[] dx = new int[4] { 0, 0, -1, 1 };
        int[] dy = new int[4] { -1, 1, 0, 0  };
        string[] dir = new string[4] { "W", "E", "N", "S" };
        int[] answer = new int[2] { 0, 0 };

        for (int i = 0; i < park.Length; i++)
        {
            string street = park[i];

            bool find = false;

            for (int j = 0; j < street.Length; j++)
            {
                if (street[j].Equals('S'))
                {
                    find = true;
                    answer[0] = i;
                    answer[1] = j;

                    break;
                }
            }
            if (find) { break; }
        }

        for (int i = 0; i < routes.Length; i++)
        {
            bool canMove = true;
            string[] arr = routes[i].Split(' ');
            string str = arr[0]; 
            int go = int.Parse(arr[1]); 

            for (int j = 0; j < dir.Length; j++)
            {
                if (str == dir[j])
                {
                    int nx = answer[0] + dx[j] * go;
                    int ny = answer[1] + dy[j] * go;

                    if (nx < 0 || ny < 0 || nx >= park.Length || ny >= park[0].Length)
                    {
                        canMove = false;
                        break;
                    }

                    for (int k = 1; k <= go; k++)
                    {
                        int cx = answer[0] + dx[j] * k;
                        int cy = answer[1] + dy[j] * k;
                        if (park[cx][cy] == 'X') { canMove = false; break; }
                    }

                    if (!canMove) { continue; }

                    answer[0] = nx;
                    answer[1] = ny;
                }
            }
        }
        return answer;
    }
}