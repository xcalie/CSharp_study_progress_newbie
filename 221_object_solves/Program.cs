namespace _221_object_solves
{
    class Test
    {

        public int i = 1;
        public Test2 t2 = new Test2();

        public Test Clone()
        {
            return MemberwiseClone() as Test;
        }

        // vs内部定义的函数可以进行重写
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

    class Test2
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Equals
            // 用于比较值类型
            Console.WriteLine(Object.Equals(1,1));

            Test test = new Test();
            Test test1 = new Test();
            Test test2 = test;
            Console.WriteLine(Object.ReferenceEquals(test, test1));
            Console.WriteLine(Object.ReferenceEquals(test,test2));
            // 用于比较引用类型
            // 用于毕竟值类型一直返回false
            #endregion

            #region 2 GetType

            Test test3 = test;
            Type type = test3.GetType();


            Test test4 = new Test();
            Test test5 = test4.Clone();
            // 浅拷贝
            // 只拷贝值类型 对引用类型的拷贝不会发生变化

            #endregion

            #region 3 override

            Test test6 = new Test();

            #endregion

        }
    }
}
