using System.Security.Cryptography.X509Certificates;

namespace _306_Generic_constraint
{
    internal class Program
    {
        class Test
        {
            public int id;
        }
        class _Test
        {
            public int id;

            public _Test(int id)
            {
                this.id = id;
            }
        }

        class Test_2 : Test
        {
            public Test_2(int id)
            {

            }
        }


        //值类型 struct
        //引用类型 class
        //存在无参构造函数 new()
        //      结构体均有  类在定义构造后会消失
        //类本身或者子类 类名
        //接口类型或子类 接口名
        //泛型类型本身 另一个泛型
        class ArrayList<T> where T : struct
        {
            public T[] array;

            public ArrayList(T[] array)
            {
                this.array = array;
            }

        }

        class Test2<T> where T : class
        {
            public T[] array;

            public Test2(T[] array)
            {
                this.array = array;
            }
        }

        // 可以组合使用
        class Test3<T> where T : class,new()
        {
            public T[] array;

            public Test3(T[] array)
            {
                this.array = array;
            }
        }


        class Test4<T> where T : Test
        {
            public T[] array;

            public Test4(T[] array)
            {
                this.array = array;
            }
        }


        public interface IFly
        {
            public int Id
            {
                get;
                set;
            }

            public void Process();
        }

        class Test5<T> where T : IFly
        {
            public T[] Array = new T[2];


        }

        // 带入的U要T为U的子类要么T为U本身
        // 多个约束申明
        class Test6<T, U> where T : U where U : Test
        {

        }


        static void Main(string[] args)
        {
            Test2<Test> member1 = new Test2<Test>(new Test[2]);

            ArrayList<int> member2 = new ArrayList<int>(new int[2]);

            //Test3<_Test>不行
            Test3<int> member3 = new Test3<int>(new int[2]);

            Test4<Test> memTest4 = new Test4<Test>(new Test[3]);
            Test4<Test_2> memTest44 = new Test4<Test_2>(new Test_2[4]);

            Test5<IFly> member5 = new Test5<IFly>();
        }
    }
}
