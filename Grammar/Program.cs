using System;
using BstTree;

namespace Grammar
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KMP kmp = new KMP();
            var index = kmp.Search("啊阿萨德大青蛙恶趣味安全阿萨德", "大青蛙");
            Console.WriteLine(index.ToString());
        }
    }
}