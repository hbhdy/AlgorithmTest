using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 서울에서 김서방 찾기

namespace AlgorithmTest
{
    public class Test20210428_2
    {
        public static string solution(string[] seoul)
        {
            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                {
                    return "김서방은 " + i.ToString() + "에 있다";
                }
            }

            return null;
        }

        public static void Main(string[] args)
        {
            string[] s = { "Jane", "main", "Kein", "Tol" };

            solution(s);

            return;
        }
    }
}
