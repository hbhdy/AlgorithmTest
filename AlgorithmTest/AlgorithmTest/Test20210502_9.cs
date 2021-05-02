using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// x만큼 간격이 있는 n개의 숫자

namespace AlgorithmTest
{
    public static class Test20210502_9
    {
        public static long[] solution(int x, int n)
        {
            long[] answer = new long[n];

            for (int i = 1; i <= n; i++)
            {
                answer[i - 1] = (long)x * i;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int x = 2;
            int n = 5;

            solution(x, n);

            return;
        }
    }
}
