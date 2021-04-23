using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 정렬
// K번째수

namespace AlgorithmTest
{
    public class Test20210422_1
    {
        public static int[] solution(int[] array, int[,] commands)
        {
            int lenth = commands.Length / 3;

            List<List<int>> datas = new List<List<int>>();

            for (int i = 0; i < lenth; i++)
            {
                datas.Add(new List<int>(array));
            }

            int[] answer = new int[commands.Length / 3];

            for (int i = 0; i < datas.Count; i++)
            {
                datas[i] = datas[i].GetRange(commands[i, 0] - 1, (commands[i, 1] - 1) - (commands[i, 0] - 1) + 1);
                datas[i].Sort();
                answer[i] = datas[i][commands[i, 2] - 1];
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            int[] answer3 = new int[3];
            answer3 = solution(array, commands);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(answer3[i]);
            }

            return;

        }
    }
}