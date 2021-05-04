using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 소수 만들기

namespace AlgorithmTest
{
    public class Test20210425_3
    {
        public static int solution(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int num = nums[i] + nums[j] + nums[k];

                        bool check = false;

                        for (int t = 2; t < num; t++)
                        {
                            if (num % t == 0)
                            {
                                check = true;
                                break;
                            }
                        }

                        if (!check)
                            count++;
                    }

                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };

            solution(a);

            return;
        }
    }
}
