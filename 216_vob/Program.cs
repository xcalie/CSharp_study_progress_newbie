namespace _216_vob
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


        #region 静态方案
        public void print1(int i, int j)
        {
            Console.WriteLine(maxGFnums);
            Console.WriteLine(maxFriendNum);
            Console.WriteLine(i + j);
        }

        #endregion

        //虚函数，用于继承子类重写
        public virtual void process1()
        {
            Console.WriteLine("!!!");
        }
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

        // ovrride重写用于重写virtual函数,可以改变类似行为
        public override void process1()
        {
            base.process1();
            // 可以通过base来保留父类行为
        }
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
