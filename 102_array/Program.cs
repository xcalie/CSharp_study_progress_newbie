namespace _102_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 定义数组
            Int32[] array;

            Int32[] array1 = new Int32[5];
            // 开5个空间，默认值为0
            Int32[] array2 = new Int32[5] { 1, 3, 4, 5, 6};
            // 两种写法没有区别
            Int32[] array3 = { 1, 3, 4, 45, 5 };

            bool[] array4 = { true, false, true };

            #endregion

            #region 遍历数组
            array = array2;


            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = 2;
            }

            array[2] = 5;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 5)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region 增加数组元素(意义不明

            Int32[] array5 = new Int32[6];

            for (int i = 0; i < array.Length; i++)
            {
                array5[i] = array[i];
            }

            array5[5] = 6;

            #endregion

            
        }
    }
}
