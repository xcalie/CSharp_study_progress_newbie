
using System;
using System.Diagnostics;

namespace _003_writeline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hello");

            Console.Write("Hello");

            // 等待用户输入直到输入一个字符
            Console.ReadKey();

            Console.WriteLine("Hello");

            // 等待用户输入，直到回车结束
            Console.ReadLine();

            Console.Write("Hello");
            // Line 会空行


        }
    }
}
