#define DEBUG
#define RELEASE
#define U2024
#define U2020


//#undef U2020


namespace _319_define_before
{
    internal class Program
    {
        static bool isRunning = true;
        static Object obj = new Object();
        static void Main(string[] args)
        {
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
            while (true)
            {
                lock (obj)
                {
                    Console.WriteLine("MainThread is running");
                    Thread.Sleep(1000);
                }
            }


        }
        // 和if else语句相似
        //预处理会类型会通过嵌套式和卫语句来选择表达
        //可以加入逻辑符号

#if DEBUG && U2024
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
#elif RELEASE && U2020
        
        static void ThreadStart()
        {
            Console.WriteLine("Thread Start");
            while (isRunning)
            {
                lock (obj)
                {
                    Console.WriteLine("Thread running");
                    Thread.Sleep(1000);
                }
            }
        }

#endif

        //前方由于undef了U2020导致此处不能通过
#if RELEASE && U2020
        // warning用来警告
        // error用来报错
#warning 运行此代码会出现死锁
        static void ThreadStart1()
        {
            Console.WriteLine("Thread Start");
            while (isRunning)
            {
                lock (obj)
                {
                    Console.WriteLine("Thread running");
                    Thread.Sleep(1000);
                }
            }
        }
        // 尽管不是真的有语法错误，实际上是阻止编译的
//#error 运行此代码会出现死锁
#endif


    }
}
