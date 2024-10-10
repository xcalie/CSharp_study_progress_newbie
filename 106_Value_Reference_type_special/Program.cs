namespace _106_Value_Reference_type_special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            string str2 = str1;

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            Console.WriteLine();

            str2 = "321";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            /*
             * string本质上会不断开辟新的堆空间来存储字符串
             * 导致空间浪费
             */

        }
    }
}
