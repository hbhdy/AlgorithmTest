using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_2
// 깊이/너비 우선 탐색(DFS/BFS)
// 타겟 넘버

namespace AlgorithmTest
{
    public class Test20210503_1
    {
        static int answer = 0;

        // 재귀 함수 DFS ( Level_2부터 적응하기 어렵다. 아직 좀 헷갈린다 )
        public static void DfsCheck(int[] numbers, int target, int sum, int index)
        {
            if (index >= numbers.Length)
            {
                if (sum == target)
                    answer++;
                return;
            }

            DfsCheck(numbers, target, sum + numbers[index], index + 1);
            DfsCheck(numbers, target, sum - numbers[index], index + 1);
        }

        public static int solution(int[] numbers, int target)
        {
            
            DfsCheck(numbers, target, 0, 0);

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 1, 1 };
            int target = 3;

            solution(array, target);

            return;

        }
    }
}