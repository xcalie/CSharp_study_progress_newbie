using System;
using System.Collections;

namespace _302_stack
{
    class Test
    {
        int id = 1;


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 这里是object类
            Stack stack = new Stack();
            // 需要申明System.Collections

            // 压
            stack.Push(1);
            stack.Push("萨达");
            stack.Push(3);
            stack.Push('a');
            stack.Push(new Test());


            // 不存在删，弹栈
            // pop会有返回值，并弹出顶端
            object v = stack.Pop();
            Console.WriteLine(v);

            v = stack.Pop();
            Console.WriteLine(v);


            // 查看栈顶,不弹出
            v = stack.Peek();
            Console.WriteLine(v);


            // 检查是否存在改元素
            if (stack.Contains("萨达"))
            {
                Console.WriteLine("存在");
            }

            // 无法更改只能清除
            // stack.Clear();


            // 循环弹栈

            // 转换为object
            Object[] array = stack.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            // foreach
            foreach (Object index in stack)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine(stack.Count);
        }
    }
}
