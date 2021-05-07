using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 위장

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210507_1
    {
        public static int solution(string[,] clothes)
        {
            Dictionary<string, int> dicData = new Dictionary<string, int>();

            // 해당 부위별 옷의 개수
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!dicData.ContainsKey(clothes[i, 1]))
                {
                    dicData.Add(clothes[i, 1], 1);
                }
                else
                    dicData[clothes[i, 1]] += 1;
            }

            int answer = 1;

            // 경우의 수 처리 (해당 종류의 옷개수 + 1), +1은 안입을 수 있기 때문이다.
            foreach(KeyValuePair<string,int> data in dicData)
            {
                answer *= (data.Value + 1);
            }

            // 옷을 전부 안입을 수는 없기때문에 -1 처리
            answer -= 1;

            return answer;
        }

        public static void Main(string[] args)
        {
            string[,] data = { { "yellowhat", "headgear" }, { "bluesunglasses", "eyewear" }, { "green_turban", "headgear" } };

            solution(data);

            return;

        }

    }
}
