namespace _217_abstract
{
    // 抽象类不能实例化，但可以当做正常类编写
    abstract class Test
    {
        public int a;
        public int b;
        public int[] c;

        public Test() 
        {
            this.a = 1;
            this.b = 2;
            this.c = new int[2];
        }

        // 抽象类只能在抽象函数写，不能实现
        // 子类继承必须实现
        // 可以使用protected
        abstract public void process();
    }


    class Test1 : Test
    {
        // 必须实现,
        // 虚方法（vob）可以选择性实现
        public override void process()
        {
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Test test = new Test();
            Test test = new Test1 ();
            // 遵循里式替换原则
        }
        
    }
}
