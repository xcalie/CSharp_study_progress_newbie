using System;
using System.Collections;

namespace _304_hashtable
{
    internal class Program
    {
        class Teat
        {
        }


        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();


            ht.Add(1, "123");
            ht.Add("123", 222);
            ht.Add(true, false);
            ht.Add(false, true);
            ht.Add(2, 222);
            // 键不能相同 值可以相同


            // 通过键来移除
            ht.Remove(1);
            // 删除不存在的键没反应


            //ht.Clear();


            Console.WriteLine(ht[2]);
            Console.WriteLine(ht["123"]);
            Console.WriteLine(ht[true]);

            // 查不到无返回值
            Console.WriteLine(ht[4]); // null


            if (ht.Contains(1))
            {
                Console.WriteLine("存在以1为键");
            }
            if (ht.ContainsKey("123"))
            {
                Console.WriteLine("存在以\"123\"为值");
            }


            // 只能改键对应的内容，不能改键
            ht[2] = 666;
            Console.WriteLine(ht[2]);
            ht[true] = 666;
            Console.WriteLine(ht[true]);



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
            foreach (DictionaryEntry item in ht)
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
