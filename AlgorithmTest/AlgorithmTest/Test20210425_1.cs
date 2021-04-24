using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 내적

namespace AlgorithmTest
{
    public class Test20210425_1
    {
        public static int solution(int[] a, int[] b)
        {
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                count += a[i] * b[i];
            }

            Console.WriteLine(count);

            return count;
        }

        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { -3, -1, 0, 2 };

            solution(a, b);

            return;
        }
    }
}
