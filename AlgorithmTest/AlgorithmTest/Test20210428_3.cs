using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 소수 찾기
namespace AlgorithmTest
{
    public class Test20210428_3
    {
        public static int solution(int n)
        {
            bool[] check = new bool[n+1];
            int count = 0;


            // 에라토스테네스의 체라는 방법으로 해결함 (해당하는 값의 배수를 모두 제외한 뒤에 남은걸 계산함)
            for (int i = 2; i <= n; i++)
            {
                if (!check[i])
                {
                    for (int j = i * 2; j <= n; j += i)
                    {
                        check[j] = true;
                    }
                }
            }

            for(int i = 2; i < check.Length; i++)
            {
                if (!check[i])
                    count++;
            }

            // 아래의 방법은 시간 효율 실패
            //for (int i = 2; i <= n; i++)
            //{
            //    bool check = false;
            //    for (int t = 2; t < i; t++)
            //    {
            //        if (i % t == 0)
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    if (!check)
            //        answer++;
            //}

            return count;
        }

        public static void Main(string[] args)
        {
            int n = 10;

            solution(n);

            return;
        }
    }
}
