using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 올바른 괄호

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210520_1
    {
        public static bool solution(string s)
        {
            Queue<bool> check = new Queue<bool>();
            if (s[0] == ')' || s[s.Length - 1] == '(')
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    check.Enqueue(false);
                else if (s[i] == ')')
                {
                    if (check.Count > 0)
                        check.Dequeue();
                    else
                        return false;
                }
            }

            if (check.Count > 0)
                return false;
            else
                return true;
        }

        public static void Main(string[] args)
        {
            string s = "(())()";

            solution(s);

            return;
        }
    }
}
