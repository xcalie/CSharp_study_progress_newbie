using System.Linq.Expressions;

namespace _009_exception_capture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 用于防止炒饭检测
            try
            {
                string str = Console.ReadLine();
                Int32 number1 = Int32.Parse(str);
                Console.WriteLine(number1);
            }
            catch
            {
                Console.WriteLine("Error!!!");
            }
            finally
            {
                Console.WriteLine("continue");
            }

            // 多次使用有助于运行全程
            try
            {
                string str = Console.ReadLine();
                Int32 number1 = Int32.Parse(str);
                Console.WriteLine(number1);
            }
            catch
            {
                Console.WriteLine("Error!!!");
            }
            finally
            {
                Console.WriteLine("continue");
            }
        }
    }
}
