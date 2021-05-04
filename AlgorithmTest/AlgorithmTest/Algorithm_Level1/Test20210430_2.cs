using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 자연수 뒤집어 배열로 만들기

namespace AlgorithmTest
{
    public class Test20210430_2
    {
        public static int[] solution(long n)
        {
            string str = n.ToString();
            int[] answer = new int[str.Length];

            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                answer[count] += int.Parse(str[i].ToString());
                count++;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            long n = 12345678;

            solution(n);

            return;
        }
    }
}
