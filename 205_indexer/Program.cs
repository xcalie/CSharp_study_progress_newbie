using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _205_indexer
{
    internal class Program
    {
        class Person
        {
            public string name;
            public char personality;
            public int age;


            public int id;
            // 用于对id的编辑
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



            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                this.friends = new int[3][];
            }


            public Person(string name, char personality, int age, int[][] friends)
            {
                this.name = name;
                this.personality = personality;
                this.age = age;
                this.id = Convert.ToInt32(personality) + age;
                this.friends = friends;
            }

        }

        static int[][] build()
        {
            return new int[][] {
                new int[]{ 1, 2, 3, 4, 5 },
                new int[]{ 2, 3, 4 },
                new int[]{ 2 ,3, 4 },    
            };;
        }

        static void Main(string[] args)
        {
            Person person;
            person = new Person("甲", 'e', 24, build());
            Console.WriteLine(person.friends[2][0]);
        }
    }
}
