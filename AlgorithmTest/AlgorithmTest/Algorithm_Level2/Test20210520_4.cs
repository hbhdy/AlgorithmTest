using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// N개의 최소공배수

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210520_4
    {
        // 유클리드 호제법(Euclidean Algorithm)
        public static int solution(int[] arr)
        {
            Array.Sort(arr);

            // 최대공약수 GCD(Greatest Common Divisor)
            int gcd;
            // 최소공배수 LCM(Least Common Multiple)
            int lcm = 0;

            // 가장 작은 두 개의 수로 최대공약수를 구한다.
            gcd = GCD(arr[1], arr[0]);
            // 최소 공배수 구함
            lcm = LCM(arr[1], arr[0], gcd);

            // 나머지 모든 수는 곱해서 최대공약수로 나눈다.
            for (int i = 2; i < arr.Length; i++)
            {
                lcm = LCM(lcm, arr[i], gcd);
            }

            return lcm;
        }

        // 최대 공약수
        public static int GCD(int bigNum, int smallNum)
        {
            int temp = 0;

            while (smallNum != 0)
            {
                temp = bigNum % smallNum;
                bigNum = smallNum;
                smallNum = temp;
            }

            return bigNum;
        }

        // 최소 공배수
        public static int LCM(int bigNum, int smallNum, int gcd)
        {
            if (gcd == 0)
                return 0;

            int result = (bigNum * smallNum) / GCD(bigNum,smallNum);

            return result;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 14, 2, 7 };

            solution(arr);

            return;
        }
    }
}
