using System;
using System.Collections.Generic;

namespace GenerateParenthesis_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateParenthesis(3));
        }

        private static List<string> GenerateParenthesis(int n)
        {
            _generate(0, 2 * n, "");
            return null;
        }

        private static void _generate(int level, int max, string s)
        {
            //递归终结者
            if (level >= max)
            {
                Console.WriteLine(s);
                return;
            }

            //逻辑处理
            string s1 = s + "(";
            string s2 = s + ")";

            //进入递归下一层

            _generate(level + 1, max, s1);
            _generate(level + 1, max, s2);

            //清理这一层资源
        }
    }
}