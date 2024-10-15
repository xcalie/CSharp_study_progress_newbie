namespace _209_Overloaded_operator
{
    // 前面几个代码出现类中类不影响
    class Person
    {
        public string name;
        public char personality;
        public int age;

        #region 成员属性

        public int id;
        public int Id
        {
            get
            {
                return id + 1;
            }
            set
            {
                id = value - 1;
            }
        }

        #endregion


        #region 索引器

        public int[][] friends;
        public int this[int i, int j]
        {
            get
            {
                return friends[i][j];
            }
            set
            {
                friends[i][j] = value;
            }
        }

        #endregion


        #region 构造函数
        //public Person(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.friends = new int[this.maxFriendNum][];
        //}

        public Person(string name, char personality, int age, int[][] friends)
        {
            this.name = name;
            this.personality = personality;
            this.age = age;
            this.id = Convert.ToInt32(personality) + age;
            this.friends = friends;
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
        public static void print(int i, int j)
        {
            Console.WriteLine(maxGFnums);
            Console.WriteLine(maxFriendNum);
            Console.WriteLine(i + j);
        }
        public void print1(int i, int j)
        {
            Console.WriteLine(maxGFnums);
            Console.WriteLine(maxFriendNum);
            Console.WriteLine(i + j);
        }

        #endregion
    }

    static class Works
    {
        public static double Pi = 3.1415926;
        public static double e = 2.718;
        public static double squal(double r)
        {
            Console.WriteLine("面积已返回");
            return r * r * Pi;
        }
    }

    static class Tools
    {
        public static void Speak_add(this int value, int number1)
        {
            Console.WriteLine(value + number1);
        }

        public static int Speak_length(this Person value)
        {
            return value.friends.Length;
        }

        public static void print1(this Person value)
        {
            Console.WriteLine("wow");
        }
        // 当扩展方法与原类中的方法名相同时
        // 根据重载规则，完全一样的会优先执行
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
            person = new Person("甲", 'e', 24, Build());
            //Person.print(2, 3);

            //Console.WriteLine(Works.squal(6.0));
            //Console.WriteLine(Works.Pi);

            //int number = 6;
            //number.Speak_add(7);

            //Console.WriteLine(person.Speak_length());

            //person.print1();
            //person.print1(2, 3);

            Person girl = new Person("乙", 'i', 12, Build());
            int num = 1;
            int age_add = girl + person;
            int age_add_int = girl * num;
            
        }
    }
}
