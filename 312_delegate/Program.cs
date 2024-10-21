namespace _312_delegate
{
    delegate void MyAction();
    delegate int MyFunc(int a);
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
            
            
            test.Testfun(test.func, test.action);
        }
         static void Fun()
        {
            Console.WriteLine("123123");
        }
        
        
        static void Fun2(int a)
        {
            Console.WriteLine(a);
            
        }
        
    }
    
   

}
