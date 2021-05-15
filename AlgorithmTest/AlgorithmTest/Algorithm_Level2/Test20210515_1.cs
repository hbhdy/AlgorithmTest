using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// H-Index

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210515_1
    {
        public static int solution(int[] citations)
        {
            List<int> data = new List<int>(citations);

            int answer = 0;

            data.Sort();
            data.Reverse();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] > i)
                {
                    answer++;
                }
                else
                    break;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] temp = { 3, 0, 6, 1, 5 };

            solution(temp);

            return;
        }
    }
}
