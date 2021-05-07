using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 조이스틱

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210506_2
    {
        public static int solution(string name)
        {
            int moveCount = 0;

            // 알파벳의 해당값이 Z에서 빠른지 A에서 빠른지 판단후 값 추가 ( 같다면 A방향 )
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] - 'A' > ('Z' - name[i]) + 1)
                {
                    moveCount += ('Z' - name[i]) + 1;
                }
                else
                {
                    moveCount += name[i] - 'A';
                }
            }

            //// 테스트 5, 10, 11 계속 실패한다.
            //// 그리드가 아니라서 A나올 경우 바로 방향 회전해서 그렇다.. AAAA연속으로 중간에 나올경우 처리가 안됨
            //// A가 나오는 순간에 왼쪽 방향과 오른쪽 방향 판단 ( 시작은 오른쪽방향 )
            //bool check = false;
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == 'A')
            //    {
            //        if (name.Length - 1 > i - 1 + (name.Length - (i + 1)))
            //        {
            //            moveCount += i - 1 + (name.Length - (i + 1));
            //        }
            //        else
            //        {
            //            moveCount += name.Length - 1;
            //        }

            //        check = true;

                    
            //        break;
            //    }
            //}

            //if(!check)
            //    moveCount += name.Length - 1;


            // 다른 문제풀이로 해답 공부
            // A가 연속적으로 나오는 가장 긴 구간을 찾아서 그부분에서 좌우 방향에 대한 최단거리 비교를 하면 될것 같다.
            int count = 0;
            int max = 0;
            int turnPoint = 0;
            int endPoint = 0;

            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'A')
                {
                    count++;
                }
                // 연속된 A가 이전의 A연속보다 클 경우
                else if (count > max)
                {
                    max = count;
                    turnPoint = i - max - 1; // 연속 A값까지 제외 하고, 그 전 칸을 체크
                    endPoint = i; // A의 끝이후 첫 위치를 저장
                    count = 0;
                }
            }

            if (count > max) // 연속된 A가 마지막까지 A로 끝날경우
            {
                max = count;
                endPoint = name.Length;
                turnPoint = endPoint - max - 1;
            }

            if (endPoint == name.Length)
                return moveCount + turnPoint;
            else
            {
                moveCount += name.Length;

                // 최단거리 A와 순방향의 거리비교
                int dis = -1 > turnPoint * 2 - endPoint ? turnPoint * 2 - endPoint : -1;
                return moveCount + dis;
            }
        }

        public static void Main(string[] args)
        {
            string name = "JAN";
  
            solution(name);

            return;

        }
    }
}
