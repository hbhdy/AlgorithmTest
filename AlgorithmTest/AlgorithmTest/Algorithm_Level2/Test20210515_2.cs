using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 스택 / 큐
// 주식가격

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210515_2
    {
        public static int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];
            int count = 0;


            // 문제에 조금 당황했다..
            // 가격이 떨어지는 순간 바로 다음으로 넘어가야한다는게 이해하기 어려웠음 ( 기간 )
            while (true)
            {
                int num = 0;
                for (int i = count+1; i < prices.Length; i++)
                {
                    num++;
                    if (prices[i] < prices[count])
                        break;
                }

                answer[count] = num;

                count++;
                if (prices.Length == count)
                    break;
            }
            return answer;
        }

        public static void Main(string[] args)
        {
            int[] temp = { 1, 2, 3, 2, 3 };

            solution(temp);

            return;
        }
    }
}
