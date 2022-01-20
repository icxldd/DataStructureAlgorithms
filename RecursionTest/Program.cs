using System;

namespace RecursionTest
{
    class Program
    {
        static int Recursion(int val)
        {
            if (val >= 100)
            {
                return val;
            }

            val += 1;
            var intVal = Recursion(val);
            intVal += 1;
            return intVal;
        }

        static void Main(string[] args)
        {
            int a = Recursion(0);
            Console.WriteLine(a.ToString());
        }
    }
}