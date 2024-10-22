namespace _315_lambda
{
    public class Test
    {
        Func<int, int> action;

        public Test(Func<int, int> action)
        {
            this.action = action;

        }


        public Func<int, int> GetAction(int x)
        {
            x++;

            return (int a) =>
            {
                a = x;
                a += 1;
                a += x;
                return a;
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = delegate () {
                Console.WriteLine("匿名函数");
            };
            
            // 等效匿名函数更简化的写法
            Func<int, int> func = (int x) => {

                x += 10;

                return x;
            };
            // 多个泛型，最后为返回值
            Func<int, int, int> func1 = (int x, int y) =>
            {
                return x + y;
            };

            // 不能使用-= +=来移除匿名函数
            // 可以使用f = null 来直接清除


            Test test = new Test((int a) =>
            {
                a += sizeof(int);
                return a;
            });

            Func<int, int> act1 = test.GetAction(4);
            Console.WriteLine(act1(2));
            // 用括号连用
            Console.WriteLine(test.GetAction(47)(4));
        }
    }
}