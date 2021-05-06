using System;
using System.Collections.Generic;
using System.Linq;

// 프로그래머스 코딩 테스트 연습 Level_2
// 프린터

namespace AlgorithmTest.Algorithm_Level2
{
    public class Paper
    {
        // 우선 순위
        public int priority = 0;
        // 위치
        public int location = 0;

        public Paper(int pr,int lo)
        {
            priority = pr;
            location = lo;
        }
    }

    class Test20210506_1
    {
        public static int solution(int[] priorities, int location)
        {
            Queue<Paper> que = new Queue<Paper>();
          
            for(int i = 0; i < priorities.Length; i++)
            {
                // 우선순위와 위치 초기화
                Paper data = new Paper(priorities[i],i);
                que.Enqueue(data);
            }

            int count = 1;

            while (que.Count > 0)
            {
                // 현재 큐의 우선순위 최대값
                int max = que.Max(x => x.priority);

                // 이후에 큐를 빼줘야 최대값 찾기 가능
                Paper temp = que.Dequeue();

                if (max == temp.priority)
                {
                    if (location == temp.location)
                        break;
                    count++;
                }
                // 우선순위가 아닐때 다시 뒤로간다.
                else
                {
                    que.Enqueue(temp);
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, 9, 1, 1, 1 };
            int n = 0;

            solution(nums, n);

            return;

        }
    }
}
