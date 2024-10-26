namespace _323_special_write
{
    internal class Program
    {
        class Person
        {
            public int id;
            public int age;
            public int weight;
            public int height;


            // 只有一件事可以通过=>进行
            public string Name
            {
                get => "Name";
                set => Name = value;
            }

            public Person(int a)
            {

            }

            public int Add(int a, int b) => a + b;

            public void Print(string s) => Console.WriteLine(s);
        }


        static void Main(string[] args)
        {
            //隐式变量var
            //在不确定类型时写
            //区别于object为万物之父
            //var 在赋值后便确定类型

            var number = 2;
            Console.WriteLine(number.GetType());

            var numberf = 2.0f;
            Console.WriteLine(numberf.GetType());

            var str = "Hello";
            Console.WriteLine(str.GetType());




            // 声明对象
            Person person = new Person(2) { id =  2, age = 23 };
            Person person1 = new Person(44) { id = 1 };
            Person person2 = new Person(200) { id = 2 };
            // 这里可以传入构造函数




            // 声明集合
            int[] array2 = new int[]{ 1, 2 };

            List<int> list = new List<int>() { 1, 3, 4, 5 };

            List<Person> list2 = new List<Person>()
            {
                new Person(1){ id = 2 },
                new Person(2){ id = 3, age = 23 },
                new Person(200)
            };

            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                { 1 , "2" },
                { 2 , "3" },
                { 3 , "4" },
            };





            // 匿名类型
            var v = new { id = 1, age = 23 };
            // 类型不存在但是类型匿名函数

            Console.WriteLine(v.id);
            Console.WriteLine(v.age);






            // ?可空
            int? c = null;
            // 赋值类型不能为空
            // 这里不是int为一类结构体
            // 判断是否为空
            if (c.HasValue)
            {
                c = c.Value;
            }

            // 安全获取可空类型
            int? d = null;
            // 如果为空则返回零
            Console.WriteLine(d.GetValueOrDefault());
            // 指定默认值
            Console.WriteLine(d.GetValueOrDefault(200));


            object o = null;
            if (o !=  null)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine(o?.ToString());

            int[] arrayint = null;
            Console.WriteLine(arrayint?[0]);


            Action all = null;
            if (all != null)
            {
                Console.WriteLine(all.ToString());
            }
            all?.Invoke();





            // 空合并操作符
            int? intv = null;
            //int intw = intv == null ? 100 : intv.Value;
            int intI = intv ?? 0;
            Console.WriteLine(intI);

            string? strv = null;
            string strI = strv ?? "Go!";
            Console.WriteLine(strI);




            // $构造字符串
            int a = 222;
            float b = 1.2f;
            string name = $"一个个{a}还好{b}";
            Console.WriteLine(name);




            //除去转义序列
            Console.WriteLine(@"\\\n");


            //简化（避免）
            if (true)
                Console.WriteLine(2);
            for (int i = 0; i < 1; ++i)
                Console.WriteLine(2);
            while (a == 2)
                Console.WriteLine();
        }
    }
}
