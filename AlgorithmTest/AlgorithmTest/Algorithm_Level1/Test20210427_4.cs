using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 문자열 내 마음대로 정렬하기

namespace AlgorithmTest
{
    public class Test20210427_4
    {
        public static string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };

            // n번째 앞에 붙임
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Substring(n, 1) + strings[i];
            }

            // n번째 글자 기준 정렬 (n번째 같아도 뒷자리로 알아서 정렬)
            Array.Sort(strings);

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Substring(1);
            }

            answer = strings;

            return answer;
        }

        public static void Main(string[] args)
        {
            string[] data = { "sun", "bed", "car" };

            int n = 1;

            solution(data, n);

            return;
        }
    }
}
