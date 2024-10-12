namespace _203_constructor
{
    internal class Program
    {
        internal class Program
        {
            class Person
            {
                public string name;
                public char personality;
                public int age;
                private int id;


                /*
                 * 构造函数
                 * 可以手动定义在声明时输入的参数和方法
                 * Xxx Yyyy = new Xxx (... )
                 * 以此方式进行初始化
                 */
                public Person(string name, char personality, int age)
                {
                    this.name = name;
                    this.personality = personality;
                    this.age = age;
                    this.id = Convert.ToInt32(personality) + age;
                }

                // 重载，根据输入内容不同决定调用函数
                public Person(string name, int age)
                {
                    this.name = name;
                    this.age = age;
                }

            }

            static void Main(string[] args)
            {
                
            }
            
        }
    }
}
