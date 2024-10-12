namespace _202_Access_modifier
{
    internal class Program
    {
        class Person
        {
            public string name;
            public char personality;
            public int age;
            private int id;

          
            // 访问修饰符
            /* public 可以在外部访问
             * private 只能在内部访问
             * protected 可以跨子类访问
             */
            public Person (string name, char personality, int age)
            {
                this.name = name;
                this.personality = personality;
                this.age = age;
                this.id = Convert.ToInt32(personality) + age;
            }



        }


        static void Main(string[] args)
        {
            Person Tom = new Person ("Tom", 'e', 18);
            Console.WriteLine (Tom.name);
            Console.WriteLine (Tom.personality);
            Console.WriteLine (Tom.age);
            // Console.WriteLine (Tom.id);
            // 此处不能访问到Tom
        }
    }
}
