using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 3진법 뒤집기

namespace AlgorithmTest
{
    public class Test20210425_4
    {
        public static int solution(int n)
        {
            Stack<int> value = new Stack<int>();
            int k = n;

            while (true)
            {
                if (k >= 3)
                {
                    value.Push(k % 3);
                    k = k / 3;
                }
                else
                {
                    value.Push(k);
                    break;
                }
            }

            int sum = 0;
            int i = 0;
            while (value.Count > 0)
            {
                sum += (int)(value.Pop() * Math.Pow(3, i));
                i++;
            }

            Console.WriteLine(sum);

            return sum;
        }

        public static void Main(string[] args)
        {
            int a = 125;

            solution(a);

            return;
        }
    }
}
