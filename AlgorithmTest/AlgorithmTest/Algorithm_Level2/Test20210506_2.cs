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

            // A가 나오는 순간에 왼쪽 방향과 오른쪽 방향 판단 ( 시작은 오른쪽방향 )
            bool check = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'A')
                {
                    if (name.Length - 1 > i - 1 + (name.Length - (i + 1)))
                    {
                        moveCount += i - 1 + (name.Length - (i + 1));
                    }
                    else
                    {
                        moveCount += name.Length - 1;
                    }

                    check = true;

                    
                    break;
                }
            }

            if(!check)
                moveCount += name.Length - 1;

            // 테스트 5, 10, 11 계속 실패한다.
            // 그리드가 아니라서 A나올 경우 바로 방향 회전해서 그렇다.. AAAA연속으로 중간에 나올경우 처리가 안됨
            // 고민해보자

            return moveCount;
        }

        public static void Main(string[] args)
        {
            string name = "JEROEN";
  
            solution(name);

            return;

        }
    }
}
