using System.Threading;

namespace _318_Thread
{
    internal class Program
    {
        static bool isRunning = true;
        static Object obj = new Object();
        static void Main(string[] args)
        {
            // 每个函数都是线程，但是不是主线程
            // 主函数可以被休眠
            // 在线程中也可以被休眠

            Thread t = new Thread(ThreadStart);

            t.Start();

            t.IsBackground = true;


            Console.ReadKey();

            isRunning = false;

            Console.ReadKey();

            // Abort结束线程已经被弃用
            try
            {
                t.Abort();
                t = null;
            }
            catch
            {
                Console.WriteLine("Thread is not running");
            }



            isRunning = true;
            // lock会将一个引用类型的变量做主键锁，只有当前线程才能对这个对象进行操作
            // 前线程释放了锁，其他线程才能对这个对象进行操作
            while (true)
            {
                lock (obj)
                {
                    Console.WriteLine("MainThread is running");
                    Thread.Sleep(1000);
                }
            }
            

        }

        static void ThreadStart()
        {
            Console.WriteLine("Thread Start");
            while (isRunning)
            { 
                lock (obj)
                {
                    Console.WriteLine("Thread is running");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
