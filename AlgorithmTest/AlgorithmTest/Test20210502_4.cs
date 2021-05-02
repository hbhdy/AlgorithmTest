using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 콜라츠 추측

namespace AlgorithmTest
{
    public static class Test20210502_4
    {
        public static int solution(int num)
        {
            // 하나하나 디버깅해봤는데 중간에 int값을 넘어간다. 그래서 실패했던거 같다.
            long value = num;
            for(int i = 0; i < 500; i++)
            {
                if (value == 1)
                {
                    return i;
                }

                value = value % 2 == 0 ? value / 2 : (value * 3) + 1;
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int n = 626331;

            solution(n);

            return;
        }
    }
}
