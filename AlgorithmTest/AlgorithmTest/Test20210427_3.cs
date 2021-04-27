using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 두 정수사이의 합

namespace AlgorithmTest
{
    public class Test20210427_3
    {
        public static long solution(int a, int b)
        {
            long answer = 0;

            if (a >= b)
            {
                for (int i = b; i <= a; i++)
                {
                    answer += i;
                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    answer += i;
                }
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            solution(a,b);

            return;
        }
    }
}
