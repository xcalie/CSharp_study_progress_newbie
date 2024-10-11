namespace _112_recursion
{
    internal class Program
    {
        static void Printnumber(int number, int[] array, out int ptr)
        {
            if (number == 0)
            {
                ptr = 0;
                return;
            }
            Printnumber(number / 10, array, out ptr);
            array[ptr++] = number % 10;

        }

        static void printarray(int[] array, int ptr)
        {
            for (int i = 0; i < ptr; i++)
            {
                Console.Write("{0}", array[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int ptr = 0;
            Printnumber(1354113, numbers, out ptr);

            printarray(numbers, ptr);
        }
    }
}
