using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public int solution(string[] friends, string[] gifts)
    {
        
        int answer = 0;

        Dictionary<string, int> dicTotalGive = new Dictionary<string, int>();
        Dictionary<string, int> dicTotalGet = new Dictionary<string, int>();
        Dictionary<string, int> dicToGive = new Dictionary<string, int>();
        Dictionary<string, int> dicPresentNumber = new Dictionary<string, int>();
        Dictionary<string, int> dicResult = new Dictionary<string, int>();

        for (int i = 0; i < friends.Length; i++)
        {
            dicTotalGive.Add(friends[i], 0);
            dicTotalGet.Add(friends[i], 0);
            dicResult.Add(friends[i], 0);
        }

        for (int i = 0; i < gifts.Length; i++)
        {
            StringBuilder sb = new StringBuilder();

            string giveCheckStr = "";
            string[] names = gifts[i].Split(' ');
            string give = names[0];
            string get = names[1];
            sb.Append(give);
            sb.Append("To");
            sb.Append(get);
            giveCheckStr = sb.ToString();


            if (dicToGive.ContainsKey(giveCheckStr))
            {
                dicTotalGive[give]++;
                dicTotalGet[get]++;
                dicToGive[giveCheckStr]++;
            }
            else
            {
                dicToGive.Add(giveCheckStr, 1);
                dicTotalGive[give]++;
                dicTotalGet[get]++;
            }

            sb.Clear();
        }

        for (int i = 0; i < friends.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            string A = friends[i];

            for (int j = i + 1; j < friends.Length; j++)
            {
                sb.Clear();
                if (i == j) { continue; }


                bool flag = false;
                string B = friends[j];
                sb.Append(A);
                sb.Append("To");
                sb.Append(B);

                string p = sb.ToString();

                sb.Clear();
                sb.Append(B);
                sb.Append("To");
                sb.Append(A);

                string reverseP = sb.ToString();


                if (dicToGive.ContainsKey(p) || dicToGive.ContainsKey(reverseP))
                {
                    int n1 = 0;
                    int n2 = 0;

                    if (!dicToGive.ContainsKey(p)) { n1 = 0; }
                    else { n1 = dicToGive[p]; }

                    if (!dicToGive.ContainsKey(reverseP)) { n2 = 0; }
                    else { n2 = dicToGive[reverseP]; }

                    if (n1 > n2) { dicResult[A]++; flag = true; }
                    else if (n1 < n2) { dicResult[B]++; flag = true; }
                }

                if (flag) { continue; }

                int num1 = dicTotalGive[A];
                int num2 = dicTotalGet[A];
                int num3 = dicTotalGive[B];
                int num4 = dicTotalGet[B];

                dicPresentNumber[A] = num1 - num2;
                dicPresentNumber[B] = num3 - num4;

                if (dicPresentNumber[A] > dicPresentNumber[B])
                {
                    dicResult[A]++;
                }
                else if (dicPresentNumber[A] < dicPresentNumber[B])
                {
                    dicResult[B]++;
                }
            }
        }
        answer = dicResult.Values.Max();

        return answer;
    }
}