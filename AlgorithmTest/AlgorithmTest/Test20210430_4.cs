using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 정수 제곱근 판별

namespace AlgorithmTest
{
    public class Test20210430_4
    {
        public static long solution(long n)
        {
            double d = Math.Sqrt(n);

            if (d % 1 == 0)
            {
                return (long)Math.Pow(d + 1, 2);
            }
            else
            {
                return -1;
            }
        }

        public static void Main(string[] args)
        {
            long n = 121;

            solution(n);

            return;
        }
    }
}
