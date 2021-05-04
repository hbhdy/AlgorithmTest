using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 수박수박수박수박수박수?

namespace AlgorithmTest
{
    public class Test20210428_4
    {
        public static string solution(int n)
        {
            string answer = "";

            for (int i = 0; i < n / 2; i++)
            {
                answer += "수박";
            }

            if (n % 2 != 0)
                answer += "수";

            return answer;
        }

        public static void Main(string[] args)
        {
            int n = 10;

            solution(n);

            return;
        }
    }
}
