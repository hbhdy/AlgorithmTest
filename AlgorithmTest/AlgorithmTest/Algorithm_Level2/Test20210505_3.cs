using System;
using System.Collections.Generic;
using System.Text;
// 프로그래머스 코딩 테스트 연습 Level_2
// 가장 큰 수

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210505_3
    {
        // 한번의 실패후 코드 모두 지움
        // 다시 시작
        public static string solution(int[] numbers)
        {
            List<string> strNums = new List<string>();

            for(int i = 0; i < numbers.Length; i++)
            {
                strNums.Add(numbers[i].ToString());
            }

            // 앞뒤 숫자랑 뒤앞숫자를 string 정렬 판별
            strNums.Sort((x, y) => (y + x).CompareTo(x + y));

            //// string 인스턴스 생성으로 메모리 비효율..
            //string answer = "";
            //for (int i = 0; i < strNums.Count; i++)
            //{
            //    answer += strNums[i];
            //}
            //return answer;

            // 이걸 안넣으면 11번째에서 계속 실패
            if (strNums[0] == "0")
                return "0";

            // StringBuilder로 하면 
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < strNums.Count; i++)
            {
                builder.Append(strNums[i]);
            }

            string answer = builder.ToString();

            return answer;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 3, 30, 34, 5, 9 };

            solution(nums);

            return;

        }
    }
}
