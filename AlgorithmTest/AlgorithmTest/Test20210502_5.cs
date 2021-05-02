using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 평균 구하기

namespace AlgorithmTest
{
    public static class Test20210502_5
    {
        public static double solution(int[] arr)
        {
            double answer = 0;

            foreach (int a in arr)
            {
                answer += a;
            }

            return answer / arr.Length;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            solution(arr);

            return;
        }
    }
}
