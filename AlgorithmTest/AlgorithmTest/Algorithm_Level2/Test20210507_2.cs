using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 큰 수 만들기

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210507_2
    {
        public static string solution(string number, int k)
        {
            StringBuilder temp = new StringBuilder();
            string answer = "";

            // 풀다가 부분적으로 실패해서 다른 풀이로 해답 공부
            int start = 0;
            int end = k;

            char max = '0';
            int maxIndex = 0;

            // 길이에 맞는 문자열 삽입
            for (int i = 0; i < number.Length - k; i++)
            {
                // 영역 설정후 최대값 판단 
                for (int j = start; j <= end; j++)
                {
                    if (max < number[j])
                    {
                        max = number[j];
                        maxIndex = j;
                    }
                }

                // StringBuilder로 하지 않으면 시간 초과뜸
                temp.Append(max.ToString());
                start = maxIndex + 1;
                end++;
                max = '0';
            }

            answer = temp.ToString();

            return answer;
        }

        public static void Main(string[] args)
        {
            string data = "4177252841";
            int k = 3;

            solution(data, k);

            return;
        }
    }
}
