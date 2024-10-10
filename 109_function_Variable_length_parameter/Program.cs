namespace _109_function_Variable_length_parameter
{
    internal class Program
    {   

        /*
         *变成参数，只能为数组
         *在载入时会将参数自动转为数组并储存
         *并且只能放在最后且唯一
         */
        static int[] progress(int number1, int number2, params int[] array)
        {
            array[number1] = number2;
            return array;
        }

        static void Main(string[] args)
        {
            int[] numbers;

            numbers = progress(1, 2,  3, 4, 5, 6, 7, 8);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
