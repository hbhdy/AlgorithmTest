using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 로또의 최고 순위와 최저 순위

namespace AlgorithmTest
{
    public class Test20210427_1
    {
        public static int[] solution(int[] lottos,int[] win_nums)
        {
            int[] answer = new int[2];

            List<int> lottosList = new List<int>(lottos);
            List<int> win_numsList = new List<int>(win_nums);

            int count = 0;
            int etc = 0;
            // 기본적으로 맞은 수 
            for (int i = 0; i < lottosList.Count; i++)
            {
                if (lottosList[i] == 0)
                {
                    etc++;
                    continue;
                }

                if (win_numsList.Contains(lottosList[i]))
                {
                    count++;
                }
            }

            answer[0] = count;
            answer[1] = count + etc;

            for (int i = 0; i < 2; i++)
            {
                switch (answer[i])
                {
                    case 2:
                        answer[i] = 5;
                        break;
                    case 3:
                        answer[i] = 4;
                        break;
                    case 4:
                        answer[i] = 3;
                        break;
                    case 5:
                        answer[i] = 2;
                        break;
                    case 6:
                        answer[i] = 1;
                        break;
                    default:
                        answer[i] = 6;
                        break;
                }
            }

            if (answer[0] > answer[1])
            {
                int temp = answer[0];
                answer[0] = answer[1];
                answer[1] = temp;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] lottos = {44,1,0,0,31,25 };
            int[] win_nums = {31,10,45,1,6,19 };

            solution(lottos,win_nums);

            return;
        }
    }
}
