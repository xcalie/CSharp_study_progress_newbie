namespace _016_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 0;
            Int32 number2 = 0;
            if (number1 == number2)
            {
                number1 = 1;
            }
            else
            {
                number1 += number2;
            }

            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}
