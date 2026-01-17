public class Solution
{
    public string solution(string phone_number)
    {
        string answer = "";
        int idx = phone_number.Length - 4;

        for (int i=0;i<idx;i++)
        {
                answer += "*";
        }

        for (int i = idx; i < phone_number.Length; i++)
        {
            answer += phone_number[i].ToString();
        }
        return answer;
    }
}