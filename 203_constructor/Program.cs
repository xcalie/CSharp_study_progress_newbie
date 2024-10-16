﻿using System;

namespace _203_constructor
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
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                Console.WriteLine(this.age);
            }

            // 重载，根据输入内容不同决定调用函数
            public Person(string name, char personality, int age) : this(name, age)
            {
                this.name = name;
                this.personality = personality;
                this.age = age + 1;
                this.id = Convert.ToInt32(personality) + age;
            }

        }

        static void Main(string[] args)
        {
            Person person = new Person("甲", 'e', 24);
            Console.WriteLine(person.name);
            Console.WriteLine(person.personality);
            Console.WriteLine(person.age);
        }
            
    }
    
}
