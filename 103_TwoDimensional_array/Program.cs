namespace _103_TwoDimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 定义数组

            Int32[,] array = new int[3, 7]
            {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 1, 2, 3, 4, 5, 6, 7 },
                { 1, 2, 3, 4, 5, 6, 7 },
            };

            Int32[,] array1 = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 1, 2, 3, 4, 5, 6, 7 },
                { 1, 2, 3, 4, 5, 6, 7 },
            };

            #endregion

            #region 使用

            Console.WriteLine(array1.Length);
            // 行
            Console.WriteLine(array1.GetLength(0));
            // 列
            Console.WriteLine(array1.GetLength(1));

            array1[2, 3] = 999;

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write("{0} ",array1[i, j]);
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}