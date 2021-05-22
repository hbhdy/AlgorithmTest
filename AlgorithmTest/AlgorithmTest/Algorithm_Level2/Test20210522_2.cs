using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 행렬의 곱셈

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210522_2
    {
        public static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int q = 0; q < arr2.GetLength(0); q++)
                    {
                        answer[i, j] += arr1[i, q] * arr2[q, j];
                    }
                }
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[,] arr = { { 2, 3, 2 }, { 4, 2, 4 }, { 3, 1, 4 } };
            int[,] arr2 = { { 5, 4, 3 }, { 2, 4, 1 }, { 3, 1, 1 } };

            solution(arr, arr2);

            return;
        }
    }
}
