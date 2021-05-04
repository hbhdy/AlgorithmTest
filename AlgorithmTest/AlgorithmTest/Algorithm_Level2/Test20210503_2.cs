using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_2
// 스택 / 큐
// 기능 개발

namespace AlgorithmTest
{
    class Test20210503_2
    {

        // 다른 사람의 풀이를 해석한 뒤, 내 풀이와 병합
        public static int[] solution2(int[] progresses, int[] speeds)
        {
            Queue<int> data = new Queue<int>(progresses);
            Queue<int> speedData = new Queue<int>(speeds);
            List<int> lists = new List<int>();

            int count = 0;

            while (true)
            {
                if (data.Peek() >= 100)
                {
                    data.Dequeue();
                    speedData.Dequeue();
                    count++;
                }
                else
                {
                    for(int i = 0; i < data.Count; i++)
                    {
                        int temp = data.Dequeue();
                        temp += speedData.Peek();
                        data.Enqueue(temp);
                        // for문을 통해 빼고 다시 넣다보면 원위치가 된다.
                    }
                    if (count != 0)
                        lists.Add(count);

                    count = 0;
                }

                if (data.Count <= 0)
                {
                    lists.Add(count);
                    break;
                }
            }

            int[] answer = lists.ToArray();
            return answer;
        }


        // Queue를 사용한 적법한 풀이는 아닌거 같다...
        public static int[] solution(int[] progresses, int[] speeds)
        {
            Queue<int> data = new Queue<int>(progresses);
            List<int> lists = new List<int>();
            int num = 0;
            int day = 1;

            int count = 0;

            bool check = false;
            while (true)
            {
                if (data.Peek() + day * speeds[num] >= 100)
                {
                    check = true;
                    data.Dequeue();
                    count++;
                    num++;
                }
                else
                {
                    check = false;
                    day++;
                }

                if (!check)
                {
                    if (count != 0)
                    {
                        lists.Add(count);
                        count = 0;
                    }
                }

                if (data.Count == 0)
                {
                    lists.Add(count);
                    break;
                }
            }

            int[] answer = lists.ToArray();
            return answer;
        }

        public static void Main(string[] args)
        {
            int[] array = { 95, 90, 99, 99, 80, 99 };
            int[] speeds = { 1, 1, 1, 1, 1, 1 };

            solution2(array, speeds);

            return;

        }

    }
}
