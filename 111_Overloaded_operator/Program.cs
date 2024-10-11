namespace _111_Overloaded_operator
{

    internal class Program
    {
        static void progress(int number1 ,int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void progress(float number1 ,float number2)
        {
            Console.WriteLine(number2 + number1);
        }

        static void progress(int number1, float number2)
        {
            Console.WriteLine(number1 + Convert.ToInt32(number2));
        }

        static void progress(float number2, int number1)
        {
            Console.WriteLine(number1 * Convert.ToInt32(number2));
        }

        //static void progress(int number2, float number1)
        // 函数名不影响判断，只根据数据类型来判断
        
        static void progress(ref int number1, int number2)
        {
            number1 += number2;
            Console.WriteLine(number1 + number2);
        }

        static void progress(int number1,out int number2)
        {
            number2 = 999;
            Console.WriteLine(number1 + number2);
        }
        // ref 和 out 在重载时属于同一性质的变量
        


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            progress(1, 2);
            progress(1, 1.0f);
            progress(1.0f, 1.0f);

            int a = 2;
            int b = 3;

            progress(ref a, b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            progress(a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
