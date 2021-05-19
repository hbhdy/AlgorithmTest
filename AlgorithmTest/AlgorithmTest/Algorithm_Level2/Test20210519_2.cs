using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 코딩 테스트 연습 Level_2
// 방문 길이

namespace AlgorithmTest.Algorithm_Level2
{
    class Test20210519_2
    {
        public static int solution(string dirs)
        {
            int x = 0;
            int y = 0;
            List<string> data = new List<string>();

            for (int i = 0; i < dirs.Length; i++)
            {
                bool check = false;
                StringBuilder builder = new StringBuilder();
                int xpos = x;
                int ypos = y;

                switch (dirs[i])
                {
                    case 'U':
                        y++;
                        if (y > 5)
                        {
                            check = true;
                            y = 5;
                        }
                        break;
                    case 'D':
                        y--;
                        if (y < -5)
                        {
                            check = true;
                            y = -5;
                        }
                        break;
                    case 'R':
                        x++;
                        if (x > 5)
                        {
                            check = true;
                            x = 5;
                        }
                        break;
                    case 'L':
                        x--;
                        if (x < -5)
                        {
                            check = true;
                            x = -5;
                        }
                        break;
                }
                if (!check)
                {
                    xpos = x + xpos;
                    ypos = y + ypos;

                    builder.Append(xpos.ToString() + ypos.ToString());

                    if (!data.Contains(builder.ToString()))
                        data.Add(builder.ToString());
                }
            }

            //data = data.Distinct().ToList();

            return data.Count;
        }

        public static void Main(string[] args)
        {
            string dir = "LULLLLLLU";

            solution(dir);

            return;
        }
    }
}
