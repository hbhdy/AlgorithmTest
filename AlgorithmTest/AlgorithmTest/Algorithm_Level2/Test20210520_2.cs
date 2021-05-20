using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 최솟값 만들기

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210520_2
    {
        public static int solution(int[] A, int[] B)
        {
            int answer = 0;
            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for(int i = 0; i < A.Length; i++)
            {
                answer += A[i] * B[i];
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] a = { 1, 2 };
            int[] b = { 3, 4 };

            solution(a,b);

            return;
        }
    }
}
