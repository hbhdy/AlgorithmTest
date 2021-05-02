using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 짝수와 홀수

namespace AlgorithmTest
{
    public class Test20210502_2
    {
        public static string solution(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
                return "Odd";
        }

        public static void Main(string[] args)
        {
            int num = 14;

            solution(num);

            return;
        }
    }
}
