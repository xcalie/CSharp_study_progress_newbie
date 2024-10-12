using System.Security.Cryptography;

namespace _113_struct
{
    struct Person
    {
        // 默认为public
        public string name;
        public int personality;
        public int sex;
        public int age;
        public int[] friends;
        
        public Person(string name, int  personality, int sex, int age, int[] friends)
        {
            this.name = name;
            this.personality = personality;
            this.sex = sex;
            this.age = age;
            this.friends = friends;
        }

        // 不用带上static关键字
        public void Speak()
        {
            Console.WriteLine("我的名字是{0}，年龄是{1}", name, age);
        }
    }
    // 和类基本一致
    // 但是部分功能仅class能够实现
    // struct作为值类型一般用于小型数学计算
    // class用于实现大型商业目的
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("甲", 0, 0, 24, new int[]{ 1, 2, 3, 4 });
            person1.Speak();

            Person person2 = new Person();
            person2.name = "乙";
            person2.personality = 1;
            person2.sex = 1;
            person2.age = 18;
            person2.friends = new int[]{ 1, 2, 3, 4 };
            person2.Speak();
        }
    }
}
