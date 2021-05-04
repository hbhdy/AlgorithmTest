using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 이상한 문자 만들기

namespace AlgorithmTest
{
    public class Test20210429_4
    {
        public static string solution(string s)
        {
            string answer = "";

            // 너무 수동이다..
            // 대소문자에서는 아스키코드로 처리하긴 너무 비효율
            //string[] str = s.Split(' ');
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 2; j < str[i].Length + 2; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            // 홀수
            //            if (str[i][j - 2] > 96)
            //                answer += (char)(str[i][j - 2] - 32);
            //            else
            //                answer += str[i][j - 2];
            //        }
            //        else
            //        {
            //            // 홀수
            //            if (str[i][j - 2] < 91)
            //                answer += (char)(str[i][j - 2] + 32);
            //            else
            //                answer += str[i][j - 2];
            //        }
            //    }
            //    if (str.Length - 1 != i)
            //        answer += " ";
            //}

            int indexCount = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]==' ')
                {
                    indexCount = 0;
                    answer += " ";
                    continue;
                }

                if (indexCount % 2 == 0) // 대문자
                {
                    answer += s[i].ToString().ToUpper();
                    indexCount++;
                }
                else // 소문자
                {
                    answer += s[i].ToString().ToLower();
                    indexCount++;
                }
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            string s = "try hello world";

            solution(s);

            return;
        }
    }
}
