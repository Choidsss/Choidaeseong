public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string[] strs = s.Split(' ');

        for (int i = 0; i<strs.Length; i++)
        {
            string word = strs[i];

            for(int j = 0; j < word.Length; j++)
            {
                char c = word[j];

                if(j == 0)
                {
                    answer += char.ToUpper(c);
                }
                else
                {
                    answer += char.ToLower(c);
                }
            }

            if(i == strs.Length - 1)
            {
                break;
            }

            answer += ' ';
        }
        return answer;
    }
}