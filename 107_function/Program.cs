using System.Runtime.CompilerServices;

namespace _107_function
{
    internal class Program
    {
        static void progress()
        {
            Console.WriteLine("1 : Hello, World!");
        }

        static int progressInt()
        {
            return 123;
        }

        static void progressArray(int[] array)
        {
            // 数组传递进来的本质是地址
            array[0] = progressInt();
        }

        static bool progressBool(int[] array)
        {
            return array[0] > array[1];
        }

        static void Main(string[] args)
        {
            progress();

            int number1 = progressInt();

            int[] number2 = new int[] { 1, 2 };

            progressArray(number2);

            Console.WriteLine(number2[0]);

            Console.WriteLine(progressBool(number2));
        }
    }
}
