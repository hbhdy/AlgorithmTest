using System;
using System.Collections.Generic;
// 프로그래머스 코딩 테스트 연습 Level_2
// 2021 Dev-Matching: 웹 백엔드 개발자(상반기)
// 행렬 테투리 회전하기

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210505_1
    {
        public static int[] solution(int rows, int columns, int[,] queries)
        {
            List<int> nums = new List<int>();
            Queue<int> queue = new Queue<int>();
            int[,] cell = new int[rows, columns];

            // 행렬 초기화
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    cell[i, j] = (i * columns + j + 1);
                }
            }

            int min = 0;

            // 큐 삽입
             for (int i = 0; i < queries.GetLength(0); i++)
            {
                // 기본 회전 큐 삽입
                for (int c = queries[i, 1]; c <= queries[i, 3]; c++)
                {
                    queue.Enqueue(cell[queries[i, 0] - 1, c - 1]);
                }

                for (int c = queries[i, 0]; c <= queries[i, 2]; c++)
                {
                    if (!queue.Contains(cell[c - 1, queries[i, 3] - 1]))
                        queue.Enqueue(cell[c - 1, queries[i, 3] - 1]);
                }

                for (int c = queries[i, 3]; c >= queries[i, 1]; c--)
                {
                    if (!queue.Contains(cell[queries[i, 2] - 1, c - 1]))
                        queue.Enqueue(cell[queries[i, 2] - 1, c - 1]);
                }

                for (int c = queries[i, 2]; c >= queries[i, 0]; c--)
                {
                    if (!queue.Contains(cell[c - 1, queries[i, 1] - 1]))
                        queue.Enqueue(cell[c - 1, queries[i, 1] - 1]);
                }

                //맨앞의 큐값을 최소값으로 설정
                min = queue.Peek();

                // 회전하는 네모의 왼쪽 상단 구석에서 오른쪽으로 한 칸옆의 자리부터 큐 삽입
                for (int c = queries[i, 1] + 1; c <= queries[i, 3]; c++)
                {
                    if (min > queue.Peek())
                        min = queue.Peek();

                    cell[queries[i, 0] - 1, c - 1] = queue.Dequeue();
                }

                for (int c = queries[i, 0] + 1; c <= queries[i, 2]; c++)
                {
                    if (min > queue.Peek())
                        min = queue.Peek();

                    cell[c - 1, queries[i, 3] - 1] = queue.Dequeue();
                }

                for (int c = queries[i, 3] - 1; c >= queries[i, 1]; c--)
                {
                    if (min > queue.Peek())
                        min = queue.Peek();

                    cell[queries[i, 2] - 1, c - 1] = queue.Dequeue();
                }

                for (int c = queries[i, 2] - 1; c >= queries[i, 0]; c--)
                {
                    if (min > queue.Peek())
                        min = queue.Peek();

                    cell[c - 1, queries[i, 1] - 1] = queue.Dequeue();
                }

                // 최소값 추가
                nums.Add(min);
            }

            int[] answer = nums.ToArray();
            return answer;
        }

        public static void Main(string[] args)
        {
            int[,] array = { { 1, 1, 100, 97 } };

            solution(100, 97, array);

            return;

        }

    }
}
