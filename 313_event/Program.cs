namespace _313_event
{

    public class Test
    {
        public Action action;
        public  Func<int, int> func;
        public Func<string, string> func1;
        
        
        public event Func<int, int> t;
        
        
        
        public Test(Action action, Func<int, int> func, Func<string, string> func1)
        {
            this.action = action;
            this.func = func;
            this.func1 = func1;
            t += func;
            t += func;
            Console.WriteLine(t(2));
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(Act1, Func1, Func2);

            //Console.WriteLine(test.t(2));
            // 外部不能对事件进行修改
            // 在外部也不能赋值
            // 本质和事件一样
            
            // 只能在类内部调用赋值
            test.t -= test.func;
            // 但是可以加减赋值对应功能
        }
        
        public static void Act1()
        {
            Console.WriteLine("Hello");
        }
        
        
        public static int Func1(int x)
        {
            return x;
        }

        public static string Func2(string x)
        {
            return x.ToString();
        }
    }
}
