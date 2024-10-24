﻿namespace _316_list_sort
{
    public class Test : IComparable<Test>
    {
        public int id;
        public string name;
        public int age;

        public Test()
        {
            id = 0;
            name = "test";
            age = 0;
        }
        

        public Test(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Test? other)
        {
            // 等于零 为不变
            // 小于0 放在前面
            // 大于0 放在后面

            if (other == null) return 0;
            if (this.age < other.age)
            {
                return -1;
            }
            else
            {
                return 1;
            }
            return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(2);

            list.Sort();
            
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            //自带的排序
            Console.WriteLine("***************");

            List<Test> list2 = new List<Test>();
            
            list2.Add(new Test(2,"b",20));
            list2.Add(new Test(1,"a",10));
            list2.Add(new Test(4,"d",40));
            list2.Add(new Test(3,"c",30));

            list2.Sort();

            foreach (Test i in list2)
            {
                Console.WriteLine(i.age + " " + i.name);
            }

            Console.WriteLine("**************");


            List<Test> tests = new List<Test>();


            tests.Add(new Test(2, "b", 20));
            tests.Add(new Test(1, "a", 10));
            tests.Add(new Test(4, "d", 40));
            tests.Add(new Test(3, "c", 30));

            tests.Sort((Test a, Test b) =>
            {
                if (a.id < b.id)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
                return 0;
            });

            // 打印内部
            foreach (var item in tests)
            {
                Console.WriteLine(item.id + " " +item.age);
            }
            
            Console.WriteLine("**************");

            List<Test> test2 = new List<Test>();


            test2.Add(new Test(2, "b", 20));
            test2.Add(new Test(1, "a", 10));
            test2.Add(new Test(4, "d", 40));
            test2.Add(new Test(3, "c", 30));


            test2.Sort(Func);

            foreach (Test item in test2)
            {
                Console.WriteLine(item.id + " " + item.age);
            }
            
            
        }

        public static int Func (Test a, Test b)
        {
            if (a.id > b.id)
            {
                return -1;
            }
            else
            {
                return 1;
            }
            return 0;
        }
    }
}
