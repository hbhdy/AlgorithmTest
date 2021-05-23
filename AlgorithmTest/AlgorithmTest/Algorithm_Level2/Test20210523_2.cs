using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// JadenCase 문자열 만들기

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210523_2
    {
        public static string solution(string s)
        {
            s = s.ToLower();

            char[] ch = s.ToCharArray();

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < ch.Length; i++)
            {
                if (i == 0)
                {
                    builder.Append(ch[i].ToString().ToUpper());
                }
                else
                {
                    if (ch[i - 1] == ' ')
                    {
                        builder.Append(ch[i].ToString().ToUpper());
                    }
                    else
                    {
                        builder.Append(ch[i]);
                    }
                }
            }

            string answer = builder.ToString();
            return answer;
        }

        public static void Main(string[] args)
        {
            string s = "3people unFollowed me";

            solution(s);

            return;
        }
    }
}
