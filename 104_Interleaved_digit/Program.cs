namespace _104_Interleaved_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] number = new int[][] {
                new int[] {1, 2, 3, 4, 5 },
                new int[] {1, 2, 4 },
                new int[] {1, 2 }
            };

            int[] leng = new int[] { number[0].Length, number[1].Length, number[2].Length };

            Console.WriteLine(leng[0]);
            Console.WriteLine(leng[1]);   
            Console.WriteLine(leng[2]);
            Console.WriteLine(leng[0] + leng[1] + leng[2]);

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < leng[i]; j++)
                {
                    Console.Write("{0} ", number[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
