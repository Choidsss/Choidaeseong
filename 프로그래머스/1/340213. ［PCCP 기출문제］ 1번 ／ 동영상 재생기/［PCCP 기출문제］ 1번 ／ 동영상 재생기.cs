using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string answer = "";
        int min = 0;
        int sec = 0;
        string[] videoLen = video_len.Split(':');
        string[] videoPos = pos.Split(':');
        string[] startOp = op_start.Split(':');
        string[] endOp = op_end.Split(':');
        int totalVideoTime = int.Parse(videoLen[0]) * 60 + int.Parse(videoLen[1]);
        int totalPosTime = int.Parse(videoPos[0]) * 60 + int.Parse(videoPos[1]);
        int totalStartOpTime = int.Parse(startOp[0]) * 60 + int.Parse(startOp[1]);
        int totalEndOpTime = int.Parse(endOp[0]) * 60 + int.Parse(endOp[1]);
        dic.Add("prev", -10);
        dic.Add("next", 10);

        if (totalPosTime >= totalStartOpTime && totalPosTime <= totalEndOpTime) { totalPosTime = totalEndOpTime; }
        if(totalPosTime >= totalVideoTime) { totalPosTime = totalVideoTime; }
        if(totalPosTime <= 0) { totalPosTime = 0; }

        for (int i = 0; i < commands.Length; i++)
        {
            switch (commands[i])
            {
                case "prev":
                    totalPosTime += dic["prev"];
                    break;
                case "next":
                    totalPosTime += dic["next"];
                    break;
            }

            if (totalPosTime < 0) { totalPosTime = 0; }
            if (totalPosTime > totalVideoTime) { totalPosTime = totalVideoTime; }
            
            if (totalPosTime >= totalStartOpTime && totalPosTime <= totalEndOpTime)
            {
                totalPosTime = totalEndOpTime;
            }
        }

        min = totalPosTime / 60;
        sec = totalPosTime % 60;

        if (min <= 9) { answer +="0"; }
        answer += min.ToString();
        answer += ":";
        if (sec <= 9) { answer += "0"; }
        answer += sec.ToString();

        return answer;
    }
}