public class Solution
{
    public string solution(string s)
    {
        
        string answer = "";
        string[] strArr = s.Split(' ');

        for (int i=0;i< strArr.Length;i++)
        {
            int cnt = 0;
            string str = strArr[i];

            while (cnt < strArr[i].Length)
            {
                if (cnt % 2 == 0)
                {
                    answer += char.ToUpper(str[cnt]).ToString();
                    cnt++;
                }
                else
                {
                    answer += char.ToLower(str[cnt]).ToString();
                    cnt++;
                }
            }

            if(i != strArr.Length - 1)
            {
                answer += " ";
            }
        }

        return answer;
    }
}