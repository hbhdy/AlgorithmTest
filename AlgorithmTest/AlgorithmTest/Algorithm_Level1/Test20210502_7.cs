using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_1
// 핸드폰 번호 가리기

namespace AlgorithmTest
{
    public static class Test20210502_7
    {
        public static string solution(string phone_number)
        {
            string answer = "";

            int count = phone_number.Length;

            phone_number = phone_number.Substring(count - 4, 4);

            for (int i = 0; i < count - 4; i++)
            {
                answer += "*";
            }

            answer += phone_number;

            return answer;
        }

        public static void Main(string[] args)
        {
            string number = "01033334444";

            solution(number);

            return;
        }
    }
}
