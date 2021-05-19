using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 스킬트리

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210519_1
    {
        public static int solution(string skill, string[] skill_trees)
        {
            int answer = 0;
            int treeLength = skill_trees.Length;

            // 단어 수 만큼 for문 
            for(int i = 0; i < treeLength; i++)
            {
                bool check = true;
                char[] str = skill_trees[i].ToCharArray();
                int count = 0;

                for(int j = 0; j < str.Length; j++)
                {
                    // 해당 첫 문자를 통과하지못하면 컷
                    if (count < skill.IndexOf(str[j]))
                    {
                        Console.WriteLine(skill.IndexOf(str[j]));
                        check = false;
                        break;
                    }
                    else if (count == skill.IndexOf(str[j]))
                    {
                        count++;
                    }
                }

                if (check)
                    answer++;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            string skill = "CBD";
            string[] trees = { "BACDE", "CBADF", "AECB", "BDA" };

            solution(skill, trees);

            return;
        }
    }
}
