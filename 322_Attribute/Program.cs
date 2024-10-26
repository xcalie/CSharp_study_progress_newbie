#define FUN

using System.Runtime.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace _322_Attribute
{
    internal class Program
    {
        [DllImport("Test.dll")]
        public static extern int Add(int a, int b);


        // 继承基类特性
        [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
        class MyCustomAttribute : Attribute
        {
            // 特性中的成员自行定义
            public string info;

            public MyCustomAttribute(string info)
            {
                this.info = info;
            }

            public void TestFun()
            {
                Console.WriteLine(this.info);
                Console.WriteLine("特性方法");
            }
        }

        [MyCustom("用于计算")]
        [MyCustom("用于计算")]
        class MyClass
        {
            [MyCustom("用于存储")]
            public int value;

            public void TestFun([MyCustom("函数参数")]int a)
            {

            }

        }

        //  “|”可以用于连接
        // Attribute 表示特性能用于的地方
        // AllowMultiple 是否多个特性能否用于同一个对象上
        // Inherited 是否能被继承
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true, Inherited = true)]
        public class MyCustomAttribute2 : Attribute
        {


        }

        
        public class TestClass
        {
            // Obsolete 表示一种弃用
            // true 在使用的时候就报错
            // false 则是警告
            [Obsolete("该方法已过时，建议更换", false)]
            public void OldSpeak(string str)
            {

            }


            public void Speak()
            {

            }

            // CallerFilePath可以找到路径
            // CallerLineNumber可以找到函数
            // CallerMemberName可以找到执行函数
            // using System.Runtime.CompilerServices;需要引用
            public void SpeakCaller(string str, [CallerFilePath]string filename = "", [CallerLineNumber]int line = 0, [CallerMemberName] string target ="")
            {
                Console.WriteLine(str);
                Console.WriteLine(filename);
                Console.WriteLine(line);
                Console.WriteLine(target);
            }


            // 同 #define 与 #if #endif 
            [Conditional("FUN")]
            public static void Fun()
            {
                Console.WriteLine("FUN执行");
            }

        }




        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();
            Type type = myClass.GetType();
            
            // 参数1 为特性类型 参数2 为是否搜索继承的属性
            // 属性和事件忽略此事件
            if (type.IsDefined(typeof(MyCustomAttribute), false))
            {
                Console.WriteLine("该类型应用了特性");
            }

            
            // 参数为是否搜索继承的特性
            object[] objects = type.GetCustomAttributes(false);
            for (int i = 0; i < objects.Length; i++)
            {
                if ( objects[i] is MyCustomAttribute)
                {
                    Console.WriteLine((objects[i] as MyCustomAttribute).info);
                    (objects[i] as MyCustomAttribute).TestFun();

                }
            }



            TestClass testClass = new TestClass();
            testClass.OldSpeak("111");


            testClass.SpeakCaller("1231231231231");


            TestClass.Fun();
        }
    }
}
