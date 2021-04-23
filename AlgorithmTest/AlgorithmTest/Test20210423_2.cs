using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 가운데 글자 가져오기

namespace AlgorithmTest
{
    public class Test20210423_2
    {
        public static string solution(string s)
        {
            int a = 0;

            if (s.Length % 2 == 0) // 짝수
            {
                a = s.Length / 2 - 1;
                s = s.Substring(a, 2);
            }
            else
            {
                a = s.Length / 2;
                s = s.Substring(a, 1);
            }
            return s;
        }

        public static void Main(string[] args)
        {
            string s = "abcde";

            solution(s);

            return;
        }
    }
}
