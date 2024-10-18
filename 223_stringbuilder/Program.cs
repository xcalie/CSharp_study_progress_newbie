using System;
using System.Text;

namespace _223_stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 可以提前创建空间 20 
            StringBuilder sb = new StringBuilder("123123123", 20);
            Console.WriteLine(sb.ToString());

            // 容量为最大字符数,用于容量可以避免在创建新字符串
            Console.WriteLine(sb.Capacity);
            // 长度为当前字符串长度
            Console.WriteLine(sb.Length);

            // 增
            sb.Append("666");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);

            sb.AppendFormat("{0}{1}", "2342", "232345");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);

            // 插入
            sb.Insert(2, "ssss");
            Console.WriteLine(sb.ToString());

            // 删除
            sb.Remove(3, 2);
            Console.WriteLine(sb.ToString());

            // 清空
            //sb.Clear();
            //Console.WriteLine(sb.ToString());

            // 查
            Console.WriteLine(sb[3]);

            // 改，stringbuild专属
            sb[4] = 'K';
            Console.WriteLine(sb);

            // 替换
            sb.Replace("2","啊收到了");
            Console.WriteLine(sb.ToString());
        }
    }
}
