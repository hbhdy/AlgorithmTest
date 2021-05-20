using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 최댓값과 최솟값

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210520_3
    {
        public static string solution(string s)
        {
            string[] str = s.Split(' ');
            string answer = "";
            List<int> data = new List<int>();

            for(int i = 0; i < str.Length; i++)
            {
                data.Add(int.Parse(str[i].ToString()));
            }

            data.Sort();

            answer = data[0].ToString() + " " + data[data.Count - 1].ToString();

            return answer;
        }

        public static void Main(string[] args)
        {
            string s = "1 2 3 4";

            solution(s);

            return;
        }
    }
}
