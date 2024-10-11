using System.Globalization;

namespace _114_Bubble_sort
{
    class Bubble_sort
    {
        public int[] numbers;
        private int length;
        
        //public Bubble_sort(int[] numbers)
        //{
        //    this.numbers = numbers;
        //    this.length = numbers.Length;
        //}

        public Bubble_sort(params int[] numbers)
        {
            this.numbers = numbers;
            this.length = numbers.Length;
        }

        public void change(ref int number1, ref int number2)
        {
            int tack = number1;
            number1 = number2;
            number2 = tack;
        }

        public void sort()
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int ptr = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        ptr = i;
                    }
                }
                this.change(ref numbers[ptr], ref numbers[i]);
            }
        }

        public void print()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ",numbers[i]);
            }
            Console.WriteLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Bubble_sort A = new Bubble_sort(23, 45, 65, 123, 865);
            A.sort();
            A.print();
        }
    }
}
