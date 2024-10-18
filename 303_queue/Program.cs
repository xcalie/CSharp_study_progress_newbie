using System;
using System.Collections;


namespace _303_queue
{
    class Test
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();


            queue.Enqueue(1);
            queue.Enqueue(new Test());
            queue.Enqueue(3);
            queue.Enqueue("欧艾斯");


            Object v = queue.Dequeue();
            Console.WriteLine(v);
            v = queue.Dequeue();
            Console.WriteLine(v);


            v = queue.Peek();
            Console.WriteLine(v);
            v = queue.Peek();
            Console.WriteLine(v);


            if (queue.Contains("欧艾斯"))
            {
                Console.WriteLine("存在");
            }


            //queue.Clear();



            Object[] objects = queue.ToArray();
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine(objects[i]);
            }


            foreach (Object index in queue)
            {
                Console.WriteLine(index);
            }

        }
    }
}
