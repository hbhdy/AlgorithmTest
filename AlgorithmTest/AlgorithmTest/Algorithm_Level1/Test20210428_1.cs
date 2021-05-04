using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 문자열 다루기 기본

namespace AlgorithmTest
{
    public class Test20210428_1
    {
        public static bool solution(string s)
        {
            if (s.Length != 4 && s.Length != 6)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (Convert.ToInt32(s[i]) >= 58)
                    return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            string s = "1234";

            solution(s);

            return;
        }
    }
}
