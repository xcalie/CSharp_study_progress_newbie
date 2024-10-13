namespace _204_Member_attribute
{
    internal class Program
    {
        class Person
        {
            public string name;
            public char personality;
            public int age;
            public int id;

            // value为传入的值
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
            /*get 和 set可以只有一个
             * 对应只读和只写
             * 此时可以不带修饰符
             * 两个不能同时带上修饰符
             */

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                Console.WriteLine(this.age);
            }


            public Person(string name, char personality, int age) : this(name, age)
            {
                this.name = name;
                this.personality = personality;
                this.age = age + 1;
                // this.id = Convert.ToInt32(personality) + age;
            }

        }

        static void Main(string[] args)
        {
            Person person = new Person("甲", 'e', 24);
            person.Id = Convert.ToInt32(person.personality) + person.age;
            Console.WriteLine(person.Id);
        }
    }
}
