using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 시저 암호

namespace AlgorithmTest
{
    public class Test20210429_2
    {
        public static string solution(string str, int n)
        {
            string answer = "";

            char[] s = str.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    answer += " ";
                    continue;
                }
                for(int j = 1; j <= n; j++)
                {
                    if (s[i] == 'z')
                    {
                        s[i] = 'a';
                    }
                    else if (s[i] == 'Z')
                    {
                        s[i] = 'A';
                    }
                    else
                    {
                        s[i] = (char)(s[i] + 1);
                    }
                }

                answer += s[i].ToString();
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            string s = "aWeczTYhfbnVfgTYrF";

            int n = 4;

            solution(s,n);

            return;
        }
    }
}
