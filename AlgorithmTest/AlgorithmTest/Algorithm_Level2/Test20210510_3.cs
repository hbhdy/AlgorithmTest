using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 다리를 지나는 트럭

namespace AlgorithmTest.Algorithm_Level2
{
    public class Truck
    {
        public int value;
        public int length;

        public Truck(int v, int l)
        {
            value = v;
            length = l;
        }
    }

    class Test20210510_3
    {
        // 다른 해답 풀이를 보고 해석함
        public static int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int[] move = new int[truck_weights.Length];
            int index = 0;
            int answer = 0;

            while (true)
            {
                int sum = 0;
                for (int i = 0; i <= index; i++)
                {
                    // 0부터 현재 트럭까지 검사 ( 트럭이동이 다리 길이보다 짧을 경우, 현재 이동중이라는 트럭으로 판단 )
                    // sum에 더하는 것으로 이동중인 트럭으로 판단
                    if (move[i] > 0 && move[i] < bridge_length)
                    {
                        sum += truck_weights[i];
                    }
                }

                // 다음턴부터 체크, 트럭 무게 체크가 마지막인지, 합산된 무게+ 현재 진입할 트럭의 무게가 다리가 버티는 무게보다 적은지 판단
                if (answer > 0 && index < truck_weights.Length - 1 && sum + truck_weights[index + 1] <= weight)
                    index++;

                // 진입을 했던 트럭에서 아직 지나가는중인 트럭은 이동++
                for (int i = 0; i <= index; i++)
                {
                    if (move[i] <= bridge_length)
                    {
                        move[i]++;
                    }
                }

                answer++;

                // 마지막 트럭의 이동이 다리길이보다 크면 모든 트럭 지나감
                if (move[truck_weights.Length - 1] > bridge_length)
                    break;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] data = { 7,4,5,6 };
            int length = 2;
            int weight = 10;

            solution(length, weight, data);

            return;
        }
    }
}
