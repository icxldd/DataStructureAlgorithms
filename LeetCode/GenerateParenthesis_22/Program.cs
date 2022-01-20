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
            List<string> res = new List<string>();
            _generate(0, 0, n, "", res);
            return res;
        }

        private static void _generate(int left, int right, int n, string s, List<string> res)
        {
            //递归终结者
            if (left == n && right == n)
            {
                res.Add(s);
                return;
            }

            //逻辑处理
            string s1 = s + "(";
            string s2 = s + ")";

            //进入递归下一层

            if (left < n)
                _generate(left + 1, right, n, s1, res);

            if (left > right)
                _generate(left, right + 1, n, s2, res);

            //清理这一层资源
        }
    }
}