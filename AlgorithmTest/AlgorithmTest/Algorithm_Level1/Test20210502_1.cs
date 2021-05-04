using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 제일 작은 수 제거하기

namespace AlgorithmTest
{
    public class Test20210502_1
    {
        public static int[] solution(int[] arr)
        {
            int[] answer = new int[] { };
            List<int> lists = new List<int>();
            int check = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[check] > arr[i + 1])
                    check = i + 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == check)
                    continue;
                lists.Add(arr[i]);
            }

            if (lists.Count > 0)
                answer = lists.ToArray();
            else
                answer = new int[1] { -1 };

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] num = { 20, 65, 897, 12, 7, 434, 26, 76, 8, 10, 23, 63 };

            solution(num);

            return;
        }
    }
}
