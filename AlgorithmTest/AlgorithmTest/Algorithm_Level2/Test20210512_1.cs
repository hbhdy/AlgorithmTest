using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 카펫

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210512_1
    {
        public static int[] solution(int brown, int yellow)
        {
            int[] answer = new int[] { };
            int sum = brown + yellow;

            int width = 0;
            int height = 0;

            for (int i = 1; i <= sum / 3; i++)
            {
                width = i;
                height = sum / width;

                if (width >= height)
                {
                    if (sum - ((width * 2) + (height * 2) - 4) == yellow)
                    {
                        answer = new int[] { width, height };
                        break;
                    }
                }
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int brown = 18;
            int yellow = 6;

            solution(brown, yellow);

            return;
        }
    }
}
