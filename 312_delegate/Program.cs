namespace _312_delegate
{
    delegate void MyAction();
    delegate int MyFunc(int a);
    delegate T MyFunc2<T>(T a);
    // 规则与重载与函数一样


    class Test
    {
        public MyAction action;
        public MyFunc func;
        
        
        public void Testfun( MyFunc myfun,  MyAction myAction)
        {
            int i = 1;
            i *= 2;
            i += 2;
            
            this.func = myfun;
            this.action = myAction;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            
            
            test.Testfun(Fun2, Fun);


            MyAction f = null;
            f += Fun;
            f();
            // 多播委托可以同时调用多次
            f += Fun;

            f();
            
            string str = "Hello";
            MyFunc2<string> myFunc2 = null;
            myFunc2 = Fun3;
            Console.WriteLine(myFunc2(str));
        }
         static void Fun()
        {
            Console.WriteLine("123123");
        }
        
        
        static int Fun2(int a)
        {
            Console.WriteLine(a);
            return 1;
        }

        static T Fun3<T>(T a)
        {
            return a;
        }
        
    }
    
   
    // Action 无返回值
    // Func 有返回值
}
