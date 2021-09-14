using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_3
// 순위

namespace AlgorithmTest.Algorithm_Level3
{
    class Test20210914_2
    {
        public static int solution(int n, int[,] results)
        {
            int answer = 0;
            bool[,] check = new bool[n + 1, n + 1];

            // 플로이드 와샬 알고리즘 적용
            for (int i = 0; i < results.GetLength(0); ++i)
            {
                int win = results[i, 0];
                int lose = results[i, 1];

                check[win, lose] = true;
                check[lose, win] = false;
            }

            for (int k = 1; k <= n; ++k)
            {
                for (int x = 1; x <= n; ++x)
                {
                    for (int y = 1; y <= n; ++y)
                    {
                        if (check[x, k] && check[k, y])
                            check[x, y] = true;
                    }
                }
            }

            for (int x = 1; x <= n; ++x)
            {
                int count = 0;
                for (int y = 1; y <= n; ++y)
                {               
                    if (check[x, y] || check[y, x])
                        count++;
                }

                if (count == n - 1)
                    answer++;
            }

            return answer;
        }


        public static void Main(string[] args)
        {
            int[,] coms = { { 1, 2 }, { 4, 5 }, { 3, 4 }, { 2, 3 } };

            solution(5, coms);

            return;

        }
    }
}
