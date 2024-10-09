namespace _013_logical_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 5;
            Int32 number2 = 3;

            bool flag1 = (number1 > number2) && (number1 != number2);
            Console.WriteLine(flag1);

            bool flag2 = (number2 > number1) || (number2 != number1);
            Console.WriteLine(flag2);
        }
    }
}
