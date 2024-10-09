namespace _010_arithmetic_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 34;
            Int32 number2 = 23;

            number1 = number1 + number2;
            number1 = number1 - number2;
            number1 = number1 * number2;
            number1 = number1 / number2;
            number1 = number1 % number2;

            number1 *= number2;
            number1 /= number2;
            number1 %= number2;

            number1++;
            number2--;

            ++number1;
            --number2;
        }
    }
}
