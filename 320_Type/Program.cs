using System.Reflection;

namespace _320_Type
{
    public class Test
    {
        public int i;
        public string str;

        public Test()
        {

        }

        public Test(int i)
        {
            this.i = i;
        }

        public Test(int i, string str) : this(i)
        {
            this.str = str;
        }


        public void Print()
        {
            Console.WriteLine($"{i} {str}");
        }


        public void Print(string str)
        {
            Console.WriteLine($"{i} {str}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            Type t1 = a.GetType();
            Console.WriteLine(t1);
            // type可以直接储存在变量中

            Type t2 = typeof(int);
            Console.WriteLine(t2);

            // 类名必须包含命名空间
            Type t3 = Type.GetType("System.Int32");
            Console.WriteLine(t3);



            Console.WriteLine("***************");


            // 可以通过类型获取程序集并且确定
            Console.WriteLine(t1.Assembly);
            Console.WriteLine(t2.Assembly);


            Console.WriteLine("***************");  


            // 得到所有公共成员
            Type t = typeof(Test);
            // 然后得到所有公共成员
            // 需要引用命名空间 using System.Reflection;
            MemberInfo[] members = t.GetMembers();
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i].Name);
            }


            Console.WriteLine("***************");


            // 得到所有构造函数
            ConstructorInfo[] ctors = t.GetConstructors();
            for (int i = 0; i < ctors.Length; i++)
            {
                Console.WriteLine(ctors[i].Name);
            }


            Console.WriteLine("***************");


            // 调用构造函数
            ConstructorInfo ctor2 = t.GetConstructor(new Type[] { typeof(int), typeof(string) });
            Test test2 = (Test)ctor2.Invoke(new object[] { 42, "Hello" });
            test2.Print();


            ConstructorInfo ctor0 = t.GetConstructor(new Type[0] {});
            Test test0 = (Test)ctor0.Invoke(new object[] {});
            test0.Print();


            Console.WriteLine("***************");

            // 可以得到变量名
            // 但是不能得到私有类型
            FieldInfo[] fields = t.GetFields();
            for (int i = 0; i < fields.Length; i++)
            {
                Console.WriteLine(fields[i].Name);
            }


            FieldInfo f = t.GetField("i");
            Console.WriteLine(f);



            Console.WriteLine("***************");


            // 通过反射得到和获取对象的值
            Test test = new Test();
            test.i = 42;
            test.str = "Hello";
            // 通过反射得到另一个对象的值
            Console.WriteLine(f.GetValue(test));

            f.SetValue(test, 43);
            Console.WriteLine(f.GetValue(test));


            Console.WriteLine("***************");


            //通过反射的类型得到方法
            Type strType = typeof(string);

            MethodInfo[] methods = strType.GetMethods();
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i].Name);
            }
            // 存在重载就通过此方法确定方法
            MethodInfo method = strType.GetMethod("Speak", new Type[] { typeof(string) });


            // 调用方法
            // 如果为静态方法则不需要实例化传null
            string str = "xxoo";
            object obj = method.Invoke(str, new object[] { "Hello" , 2 });
            Console.WriteLine(obj);


            Console.WriteLine("***************");

            // 还有些方法可以得到类型
            // 枚举
            // 结构体
            // 有member constructor method field enum
        }
    }
}
