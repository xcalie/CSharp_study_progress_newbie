namespace _018_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 0;
            while (true)
            {
                number1++;
                if (number1 == 11)
                {
                    break;
                }
            }
            Console.WriteLine(number1);
        }
    }
}
