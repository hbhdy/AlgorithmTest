using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 다음 큰 숫자

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210523_1
    {
        public static int solution(int n)
        {
            int answer = 0;
            int num = 0;

            string temp = Convert.ToString(n, 2);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '1')
                    num++;
            }

            n++;
            while(true)
            {
                int count = 0;
                string str = Convert.ToString(n, 2);
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1')
                        count++;
                }

                if (num == count)
                {
                    answer = n;
                    break;
                }
                else
                    n++;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            int n = 78;

            solution(n);

            return;
        }
    }
}
