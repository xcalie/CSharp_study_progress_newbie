namespace _213_Inside_constructor
{
    // 前面几个代码出现类中类不影响
    public partial class Person
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


        public Person()
        {
            this.name = "";
            this.personality = ' ';
            this.age = 0;
            this.id = 0;
            this.Id = 0;
            this.friends = new int[2][];
        }

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

        /*
         * 内部类
         * 在类中的类
         * 可以通过连续点引出
         */
        public class Body
        {
            public int knee;
            public int leg;
            public int heart;

            public Body(int knee, int leg, int heart)
            {
                Console.WriteLine("访问身体");
                this.knee = knee;
                this.leg = leg;
                this.heart = heart;
            }

            public void speak_mouth()
            {
                Console.WriteLine("{0} {1} {2}", knee, leg, heart);
            }
        }

        partial void process();
    }


    /*
     * 分部类访问修饰符要一致
     * 等同于将两个类分开写
     */
    public partial class Person
    {
        // 分部方法在下文会自动填充
        partial void process()
        {
            throw new NotImplementedException();
        }

    }

    public class Brother : Person
    {

        public int BF;

        #region 构造函数

        public Brother() : base()
        {
            // 继承后来自于父类的构造函数
            this.BF = 0;
            this.friends = new int[2][];
        }
        // base 为引用父类的构造函数
        public Brother(string name, char personality, int age, int[][] friends, int BF) : base(name, personality, age, friends)
        {
            this.name = name;
            this.personality = personality;
            this.age = age;
            this.id = Convert.ToInt32(personality) + age;
            this.friends = friends;
            this.BF = BF;
        }
        // this 为引用自身的构造函数
        public Brother(char personality, string name, int age, int[][] friends, int BF) : this(name, personality, age, friends, BF)
        {
            this.name = name;
            this.personality = personality;
            this.age = age;
            this.id = Convert.ToInt32(personality) + age;
            this.friends = friends;
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

            #region 赘余

            Brother brother;
            brother = new Brother("甲", 'e', 24, Build(), 23);
            //brother.print(2);

            // 里式替换原则
            Person sister = new Brother("甲", 'e', 24, Build(), 23);
            Person[] persons = new Person[] { person, sister };

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] is Person)
                {
                    Console.WriteLine(person.Speak_length());
                }
                if (persons[i] is Brother)
                {
                    Console.WriteLine((sister as Brother).Speak_length());
                }
            }

            // 内部类的申明
            //Person.Body body = new Person.Body(12, 22, 2);

            //Console.WriteLine(Works.squal(6.0));
            //Console.WriteLine(Works.Pi);

            //int number = 6;
            //number.Speak_add(7);

            //Console.WriteLine(person.Speak_length());

            //person.print1();
            //person.print1(2, 3);

            //Person girl = new Person("乙", 'i', 12, Build());
            //int num = 1;
            //int age_add = girl + person;
            //int age_add_int = girl * num;



            #endregion

        }
    }
}
