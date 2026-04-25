using System;
using System.Text;

    public class Solution
    {
        public string solution(string X, string Y)
        {
            int[] x = new int[10];
            int[] y = new int[10];
            StringBuilder answer = new StringBuilder();

            foreach (char c in X)
            {
                x[c - '0']++;
            }

            foreach (char c in Y)
            {
                y[c - '0']++;
            }

            for (int i = 9; i >= 0; i--)
            {
                int common = Math.Min(x[i], y[i]);

                for (int j = 0; j < common; j++)
                {
                    answer.Append(i);
                }
            }

            if (answer.Equals(""))
            {
                answer.Clear().Append("-1");
            }

            if (answer[0] == '0')
            {
                answer.Clear().Append("0");
            }


            return answer.ToString();
        }
    }