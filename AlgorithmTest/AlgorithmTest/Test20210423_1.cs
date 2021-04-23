using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 2016년

namespace AlgorithmTest
{
    public class Test20210423_1
    {
        public static string solution(int a, int b)
        {
            DateTime now = new DateTime(2016, a, b);

            string answer = now.DayOfWeek.ToString();

            answer = answer.Substring(0, 3).ToUpper();
            return answer;
        }

        public static void Main(string[] args)
        {
            int a = 5;
            int b = 24;

            solution(a, b);

            return;
        }
    }
}
