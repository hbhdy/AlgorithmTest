using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 하샤드 수

namespace AlgorithmTest
{
    public static class Test20210502_6
    {
        public static bool solution(int x)
        {
            string s = x.ToString();

            int num = 0;
            for(int i = 0; i < s.Length; i++)
            {
                num += int.Parse(s[i].ToString());
            }

            if (x % num == 0)
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            int arr = 10;

            solution(arr);

            return;
        }
    }
}
