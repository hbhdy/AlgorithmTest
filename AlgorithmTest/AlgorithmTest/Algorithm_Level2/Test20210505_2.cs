using System;
using System.Collections.Generic;

// 프로그래머스 코딩 테스트 연습 Level_2
// 소수 찾기

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210505_2
    {
        // 한번의 실패후 코드 모두 지움
        // 다시 시작
        public static int solution(string numbers)
        {
            List<char> chList = new List<char>(numbers.ToCharArray());
            Dictionary<char, int> dicData = new Dictionary<char, int>();

            // 문자 정렬
            chList.Sort();
            chList.Reverse();

            // 문자로 만든 최대값
            // 각 문자가 몇개인지 계산
            string str = "";
            int max = 0;
            for(int i = 0; i < chList.Count; i++)
            {
                if (!dicData.ContainsKey(chList[i]))
                    dicData.Add(chList[i], 1);
                else
                    dicData[chList[i]] += 1;

                str += chList[i].ToString();
            }
            max = int.Parse(str.ToString());


            //에라토스테네스의 체 적용
            bool[] check = new bool[max+1];
            int answer = 0;

            for (int i = 2; i <= max; i++)
            {
                if (!check[i])
                {
                    // 배수 삭제
                    for (int j = i * 2; j <= max; j += i)
                    {
                        check[j] = true;
                    }
                }
            }

            for (int i = 2; i < check.Length; i++)
            {
                if (!check[i])
                {
                    bool next = false;
                    // 얕은 복사 조심
                    Dictionary<char, int> temp = new Dictionary<char, int>(dicData);

                    for (int j = 0; j < i.ToString().Length; j++)
                    {
                        // 해당 소수가 numbers의 개별 문자를 포함하는가?
                        if (temp.ContainsKey(i.ToString()[j]))
                        {
                            if (temp[i.ToString()[j]] != 0)
                                temp[i.ToString()[j]] -= 1;
                            else
                            {
                                // 부족하면 패스
                                next = true;
                                break;
                            }
                        }
                        else
                        {
                            // 없으면 패스
                            next = true;
                            break;
                        }
                    }

                    if (next)
                        continue;

                    answer++;
                }
            }
            return answer;
        }

        public static void Main(string[] args)
        {
            string str = "17";

            solution(str);

            return;

        }
    }
}
