using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 정수 내림차순으로 배치하기

namespace AlgorithmTest
{
    public class Test20210430_3
    {
        public static long solution(long n)
        {
            long answer = 0;
            string str = "";

            List<char> temps = new List<char>(n.ToString().ToCharArray());

            temps.Sort();
            temps.Reverse();

            for (int i = 0; i < temps.Count; i++)
            {
                str += temps[i];
            }

            answer = long.Parse(str.ToString());

            return answer;
        }

        public static void Main(string[] args)
        {
            long n = 118372;

            solution(n);

            return;
        }
    }
}
