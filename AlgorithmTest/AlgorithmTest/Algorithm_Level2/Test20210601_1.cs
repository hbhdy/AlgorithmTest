using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 이진 변환 반복하기

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210601_1
    {
        public static int[] solution(string s)
        {
            int zeroCount = 0;
            int cycleCount = 0;
            string str = s;

            while (true)
            {
                StringBuilder builder = new StringBuilder();

                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1')
                        builder.Append(str[i]);
                    else
                        count++;
                }

                str = Convert.ToString(builder.Length, 2);
                cycleCount++;
                zeroCount += count;

                if (str == "1")
                    break;
            }

            int[] answer = new int[] {cycleCount,zeroCount };
            return answer;
        }

        public static void Main(string[] args)
        {
            string s = "110010101001";

            solution(s);

        }
    }
}
