using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 약수의 합

namespace AlgorithmTest
{
    public class Test20210429_3
    {
        public static int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    answer += i;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int n = 12;

            solution(n);

            return;
        }
    }
}
