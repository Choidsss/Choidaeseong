using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        string[] answer = new string[players.Length];
        Dictionary<string, int> dic = new Dictionary<string, int>();
        Dictionary<int, string> search = new Dictionary<int, string>();

        for (int i = 0; i < players.Length; i++)
        {
            if (!dic.ContainsKey(players[i]))
            {
                dic.Add(players[i], i+1);
            }

            if (!search.ContainsKey(i+1))
            {
                search.Add(i + 1, players[i]);
            }
        }

        for (int j = 0;j<callings.Length;j++)
        {
            int swap = dic[callings[j]]; // 따라잡은 선수 기준
            string str = search[swap-1]; // 이건 따라잡힌 선수 기준
            dic[callings[j]]--; // 따라잡았으니 등수 높이고
            dic[search[swap - 1]]++; // 따라잡힌거니 등수 줄이고
            search[swap] = str;
            search[swap-1] = callings[j];
        }

        foreach (KeyValuePair<string, int> pair in dic)
        {
            answer[pair.Value - 1] = pair.Key;
        }            
        return answer;
    }
}