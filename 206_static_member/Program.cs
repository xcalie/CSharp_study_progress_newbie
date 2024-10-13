using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace _206_static_member
{
    internal class Program
    {
        class Person
        {
            public string name;
            public char personality;
            public int age;


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
            // const 常量必须初始化  static静态变量则没有这个要求
            // 静态变量中不能含有非静态变量
            public static void print(int i,int j)
            {
                Console.WriteLine(maxGFnums);
                Console.WriteLine(maxFriendNum);
                Console.WriteLine(i + j);
            }

        }

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
            Person.print(2, 3);
        }
    }
}
