using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 예산

namespace AlgorithmTest
{
    public class Test20210423_3
    {
        public static int solution(int[] d,int budget)
        {
            Array.Sort(d);

            int count = 0;

            for (int i = 0; i < d.Length; i++)
            {
                if (budget >= d[i])
                {
                    budget -= d[i];
                    count++;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int[] d = { 2, 2, 3, 3 ,7,3,4,12,23,5,4,5,4,2,20};
            int budget = 100;

            solution(d, budget);

            return;
        }
    }
}
