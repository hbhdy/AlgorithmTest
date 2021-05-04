using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 나누어 떨어지는 숫자 배열

namespace AlgorithmTest
{
    public class Test20210427_2
    {
        public static int[] solution(int[] arr, int divisor)
        { 
            List<int> data = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    data.Add(arr[i]);
                }
            }

            if (data.Count > 0)
            {
                data.Sort();
            }
            else
            {
                return new int[] { -1 };
            }

            int[] answer = data.ToArray();

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] lottos = { 5, 9, 7, 10 };
            int divisor = 5;

            solution(lottos, divisor);

            return;
        }
    }
}
