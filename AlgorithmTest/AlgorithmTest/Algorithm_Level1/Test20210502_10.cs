using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 직사각형 별찍기

namespace AlgorithmTest
{
    public static class Test20210502_10
    {
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
