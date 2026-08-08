using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[,] signals)
    {
        Dictionary<int, bool> dicIsYellow = new Dictionary<int, bool>();

        int answer = 0;
        int lcm = 1;
        bool finish = true;

        for (int i = 0;i<signals.GetLength(0);i++)
        {
            lcm = lcm * (signals[i, 0] + signals[i, 1] + signals[i, 2]);
            dicIsYellow.Add(i, false);
        }

        for (int time = 1; time <= lcm; time++)
        {
            int index = 0;

            while (true)
            {
                int cycle = signals[index, 0] + signals[index, 1] + signals[index, 2];

                if ((time-1) % cycle < signals[index, 0])
                {
                    dicIsYellow[index] = false;
                }
                else if((time-1) % cycle >= signals[index, 0] + signals[index, 1])
                {
                    dicIsYellow[index] = false;
                }
                else
                {
                    dicIsYellow[index] = true;
                }

                if(index == signals.GetLength(0) - 1) { break; }

                index++;
            }

            finish = true;

            foreach(bool result in dicIsYellow.Values)
            {
                if (!result)
                {
                    finish = false;
                    break;
                }
            }

            if (finish) 
            { 
                answer = time;
                break;
            }
        }

        if (!finish) { answer = -1; }

        return answer;
    }
}