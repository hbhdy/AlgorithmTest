using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 행렬의 덧셈

namespace AlgorithmTest
{
    public static class Test20210502_8
    {
        public static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[,] number = { { 1, 2 }, { 2, 3 } };
            int[,] number2 = { { 3, 4 }, { 5, 6 } };

            solution(number, number2);

            return;
        }
    }
}
