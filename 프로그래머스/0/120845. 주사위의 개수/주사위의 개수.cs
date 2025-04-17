using System;

public class Solution
{
    public int solution(int[] box, int n)
    {
        int height= box[0] / n; 
        int width = box[1] / n; 
        int vol = box[2] / n;

        int answer = height * width * vol;
        return answer;
    }
}