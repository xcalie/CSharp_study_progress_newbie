using System.ComponentModel.DataAnnotations;

namespace _201_class_start
{
    internal class Program
    {
        class Numbers
        {
            public int number1;
            public int number2;
            public int[] numbers;
            private int length;

            public Numbers(int number1, int number2, int[] numbers)
            {
                this.number1 = number1;
                this.number2 = number2;
                this.numbers = numbers;
                this.length = numbers.Length;
            }

            public void print()
            {
                Console.WriteLine(number1 + number2);
            }
        }


        static void Main(string[] args)
        {
            Numbers oneNumber = new Numbers( 1, 2, new int[] { 1, 2, 3 } );
            oneNumber.print();
        }
    }
}
