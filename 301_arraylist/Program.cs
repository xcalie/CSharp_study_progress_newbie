using System.Collections;

namespace _301_arraylist
{
    class Test
    {

    }

    

    internal class Program
    {
        public static void Arrprint(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList");


            #region 增

            ArrayList array1 = new ArrayList();
            array1.Add(4);
            array1.Add("完成");
            array1.Add("123");
            array1.Add(new object());
            array1.Add(new Test());

            Arrprint(array1);

            ArrayList array2 = new ArrayList();
            array2.Add("123");
            array2.Add(new object());

            array1.AddRange(array2);
            // 将array2 的变量给予array

            Arrprint(array1);


            #endregion

            #region 插入

            array1.Insert(2, new object());
            Arrprint(array1);

            #endregion

            #region 删

            // 找到一个就删
            array1.Remove("123");
            Arrprint(array1);

            // 清除指定位置
            array1.RemoveAt(4);
            Arrprint(array1);

            // 清空
            //array1.Clear();

            #endregion

            #region 查

            Console.WriteLine(array1[2]);

            // 返回是否存在
            if (array1.Contains("完成"))
            {
                Console.WriteLine("存在完成");
            }

            // 正向查找位置
            // 找到返回位置，找不到返回-1
            int index = array1.IndexOf("完2成");
            if (index == -1)
            {
                Console.WriteLine("不存在");
            }
            else
            {
                Console.WriteLine(index);
            }

            // 查找返回的是正数的位置
            index = array1.LastIndexOf("完成");
            if (index == -1)
            {
                Console.WriteLine("不存在");
            }
            else
            {
                Console.WriteLine(index);
            }

            #endregion

            #region 改

            array1[3] = 2431;
            Arrprint(array1);



            #endregion

            #region 遍历

            // 长度
            int count = array1.Count;
            Console.WriteLine(count);
            // 容量
            int length = array1.Capacity;
            Console.WriteLine(length);

            foreach (object item in array1)
            {
                Console.WriteLine(item);
            }

            #endregion

            // 存在拆装箱子
        }
    }
}
