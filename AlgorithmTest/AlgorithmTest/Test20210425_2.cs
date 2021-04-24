using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 음양 더하기

namespace AlgorithmTest
{
    public class Test20210425_2
    {
        public static int solution(int[] absolutes, bool[] signs)
        {
            int count = 0;
            for(int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i])
                {
                    count += absolutes[i];
                }
                else
                {
                    count -= absolutes[i];
                }
            }


            return count;
        }

        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            bool[] b = { true, false, false, true };

            solution(a, b);

            return;
        }
    }
}
