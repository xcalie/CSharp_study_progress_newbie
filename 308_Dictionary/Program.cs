using System.Collections;
using System.Runtime.InteropServices;

namespace _308_Dictionary
{
    internal class Program
    {
        class Teat
        {
        }


        static void Main(string[] args)
        {
            Dictionary<string, int> ht = new Dictionary<string, int>();


            ht.Add("1", 1);
            ht.Add("123", 222);
            ht.Add("true", 2);
            ht.Add("false", 5);
            ht.Add("2", 222);
            // 键不能相同 值可以相同


            // 通过键来移除
            ht.Remove("2");
            // 删除不存在的键没反应


            //ht.Clear();


            Console.WriteLine(ht["123"]);
            Console.WriteLine(ht["true"]);

            //// 查不到无返回值(失效
            //Console.WriteLine(ht["4"]); // null


            if (ht.ContainsKey("1"))
            {
                Console.WriteLine("存在以1为键");
            }
            if (ht.ContainsValue(2))
            {
                Console.WriteLine("存在以\"123\"为值");
            }

            ht.Add("2", 2);
            // 只能改键对应的内容，不能改键
            ht["2"] = 666;
            Console.WriteLine(ht["2"]);
            ht["true"] = 666;
            Console.WriteLine(ht["true"]);



            // 遍历键
            foreach (object item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 遍历值
            foreach (object item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 变量键值对
            foreach (KeyValuePair<string, int> item in ht)
            {
                Console.WriteLine("键:" + item.Key + "值:" + item.Value);
            }
            Console.WriteLine();

            // 迭代器遍历
            IDictionaryEnumerator htEnumerator = ht.GetEnumerator();
            bool flag = htEnumerator.MoveNext();
            while (flag)
            {
                Console.WriteLine("键:" + htEnumerator.Key + "值:" + htEnumerator.Value);
                flag = htEnumerator.MoveNext();
            }

        }
    }
}
