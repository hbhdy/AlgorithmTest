using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 피보나치 수

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210522_1
    {
        public static int solution(int n)
        {
            int answer = 0;

            int first = 0;
            int second = 1;

            // 자료형 넘지 않도록 하는것 같다.
            for (int i = 2; i <= n; i++)
            {
                answer = (first % 1234567) + (second % 1234567);
                answer = answer % 1234567;
                first = second % 1234567;
                second = answer;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int n = 5;

            solution(n);

            return;
        }
    }
}
