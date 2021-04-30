using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 자릿수 더하기

namespace AlgorithmTest
{
    public class Test20210430_1
    {
        public static int solution(int n)
        {
            int answer = 0;
            string str = n.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                answer += int.Parse(str[i].ToString());
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int n = 984;

            solution(n);

            return;
        }
    }
}
