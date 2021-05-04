using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 최대공약수와 최소공배수

namespace AlgorithmTest
{
    public class Test20210502_3
    {
        public static int[] solution(int n, int m)
        {
            int min = 0;
            int max = 0;

            if (n >= m)
            {
                max = n;
                min = m;
            }
            else
            {
                max = m;
                min = n;
            }

            int num = 0;

            while (true)
            {
                num = max % min;
                max = min;

                if (num == 0)
                    break;

                min = num;
            }

            int[] answer = new int[] { min, n * m / min };

            return answer;
        }

        public static void Main(string[] args)
        {
            int n = 3;

            int m = 12;

            solution(n, m);

            return;
        }
    }
}
