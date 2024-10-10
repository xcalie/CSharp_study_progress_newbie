namespace _108_function_ref_out
{
    internal class Program
    {

        static void print(int[] array, int number)
        {
            Console.WriteLine(array[0]);
            Console.WriteLine(number);
            Console.WriteLine();
        }

        /*
         *  out     ref 
         * 都可以用来表示该函数对应变量需要跟随改变
         * 本质上是跟随地址
         * 其他变量遵从生命周期和作用域
         */

        static void progressNone(int[] array, int number1)
        {
            array = new int[] { number1, 2, 3 };
            number1 = 66;
        }

        // ref 需要初始化，但不需要内部赋值
        static void progressRef1(ref int[] array, int number1)
        {
            array = new int[] { number1, 2, 3};
            number1 = 66;
        }

        static void progressRef2(int[] array, ref int number1)
        {
            array = new int[] { number1, 2, 3 };
            number1 = 66;
        }


        // out 不需要初始化，进入时默认重新定义
        // 且必须赋值
        static void progressOut1(out int[] array, int number1)
        {
            array = new[] { number1, 2, 3};
            number1 = 66;
        }

        static void progressOut2(int[] array, out int number1)
        {
            number1 = 66;
            array = new[] { number1, 2, 3 };
        }

        static void Main(string[] args)
        {
            int[] numberA = new int[] { 1, 2, 3 };
            int numberB = 23;

            progressNone(numberA, numberB);
            print(numberA, numberB);


            progressRef1(ref numberA, numberB);
            print(numberA, numberB);


            progressRef2(numberA, ref numberB);
            print(numberA, numberB);



            numberB = 23;


            progressOut1(out numberA, numberB);
            print(numberA, numberB);


            progressOut2(numberA, out numberB);
            print(numberA, numberB);
        }
    }
}
