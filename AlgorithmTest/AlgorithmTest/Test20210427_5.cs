using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 문자열 내림차순으로 배치하기

namespace AlgorithmTest
{
    public class Test20210427_5
    {
        public static string solution(string s)
        {
            string answer = "";
            List<char> str = new List<char>(s);

            str.Sort();
            str.Reverse();
            for (int i = 0; i < str.Count; i++)
            {
                answer += str[i];
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            string s = "Zbcdefg";

            solution(s);

            return;
        }
    }
}
