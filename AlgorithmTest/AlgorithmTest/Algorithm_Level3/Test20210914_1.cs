using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_3
// 네트워크

namespace AlgorithmTest.Algorithm_Level3
{
    class Test20210914_1
    {
        public static bool[] check = new bool[200];

        public static void DFS(int index, int n, int[,] computers)
        {
            check[index] = true;

            for (int i = 0; i < n; ++i)
            {
                if (!check[i] && computers[index, i] == 1)
                {
                    DFS(i, n, computers);
                }
            }
        }


        public static int solution(int n, int[,] computers)
        {
            int answer = 0;

            for (int i = 0; i < check.Length; ++i)
                check[i] = false;

            for (int i = 0; i < n; ++i)
            {
                if (!check[i])
                {
                    DFS(i, n, computers);
                    answer++;
                }
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[,] coms = { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };

            solution(3, coms);

            return;

        }
    }
}
