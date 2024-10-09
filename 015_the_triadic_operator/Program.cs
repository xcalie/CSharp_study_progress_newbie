namespace _015_the_triadic_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 1;
            Int32 number2 = 5;

            string str = (number1 > number2)? "1 > 2": "1 < 2";
            
            Console.WriteLine(str);
        }
    }
}
