namespace _105_Value_Reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 数据类型有两种
             * 
             * 值类型
             * u/d整形  浮点数  bool  结构体  char
             * 
             * 引用类型
             * 数组  string  类
             * 
             * 均在栈上申请空间
             * 但是用于类型来自于堆空间
             */

            int[] arr1 = new int[]{ 1, 2, 3 };
            int[] arr2 = arr1;
            /*
             * 这里是在堆上创建内存然后将地址给予arr1
             * arr2 获取 arr1 的地址
             * 当arr1 指向的发生改变时 arr2 指向也会改变
             */

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            arr1[0] = 99;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            // 在堆上申请空间地址传给arr2
            arr2 = new int[]{ 22, 2, 3, 4, 5 };
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

        }
    }
}
