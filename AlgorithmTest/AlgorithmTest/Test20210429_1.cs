using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 문자열을 정수로 바꾸기

namespace AlgorithmTest
{
    public class Test20210429_1
    {
        public static int solution(string s)
        {
            int answer = 0;

            if (s[0] == '-')
            {
                answer = -int.Parse(s.Substring(1, s.Length - 1).ToString());
            }
            else
            {
                answer = int.Parse(s.ToString());
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            string a = "-1234";

            solution(a);

            return;
        }
    }
}
