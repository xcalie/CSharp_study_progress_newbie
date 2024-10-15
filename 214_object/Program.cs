namespace _214_object
{
    // 前面几个代码出现类中类不影响
    public class Person
    {
        public string name;
        public char personality;
        public int age;



        #region 构造函数


        public Person()
        {
            this.name = "";
            this.personality = ' ';
            this.age = 0;
        }


        public Person(string name, char personality, int age)
        {
            this.name = name;
            this.personality = personality;
            this.age = age;
        }



        private static int maxFriendNum = 100;
        public static int maxGFnums = 1;

        #endregion


        #region 重载运算符

        /* && || 
         * [] 索引符号
         * ()强制转换
         * .特殊
         *  ? : 三目预算付
         */

        public static int operator +(Person a, Person b)
        {
            return (a.age + b.age);
        }

        public static int operator *(Person a, int b)
        {
            return (a.age * b);
        }

        #endregion


        #region 静态方案
        public void print1(int i, int j)
        {
            Console.WriteLine(maxGFnums);
            Console.WriteLine(maxFriendNum);
            Console.WriteLine(i + j);
        }

        #endregion

    }



    public class Brother : Person
    {

        public int BF;

        #region 构造函数

        public Brother() : base()
        {
            BF = 0;
        }
        // base 为引用父类的构造函数
        public Brother(string name, char personality, int age, int BF)
        {
            this.name = name;
            this.personality = personality;
            this.age = age;
            this.BF = BF;
        }

        #endregion

        #region 方案

        public void print(int a)
        {
            Console.WriteLine(a + BF);
        }

        #endregion
    }




    static class Tools
    {
        public static void Speak_add(this int value, int number1)
        {
            Console.WriteLine(value + number1);
        }


        public static void print1(this Object value)
        {
            Console.WriteLine("wow");
        }
    }

    internal class Program
    {


        static int[][] Build()
        {
            return new int[][] {
                new int[]{ 1, 2, 3, 4, 5 },
                new int[]{ 2, 3, 4 },
                new int[]{ 2 ,3, 4 },
            }; ;
        }

        static void Main(string[] args)
        {
            Person person;
            person = new Person("甲", 'e', 24);

            #region 赘余

            Object brother;
            brother = new Brother("甲", 'e', 24, 23);
            //brother.print(2);

            // 里式替换原则
            Person sister = new Brother("甲", 'e', 24, 23);
            Object[] persons = new Object[] { person, sister };
            // object 为所有类/值的父类，可以用来装载任何子类
            // 当存贮值类型时会发生拆箱装箱，会消耗性能
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] is Person)
                {
                    (person as Person).print1(1, 1);
                }
                if (persons[i] is Brother)
                {
                    // as 具有返回值需要进行处理
                    if ((sister as Brother) == null)
                    {
                        Console.WriteLine("No!!");
                    }
                    else
                    {
                        sister.print1(1, 1);
                    }
                }
            }


            #endregion

        }
    }
}
