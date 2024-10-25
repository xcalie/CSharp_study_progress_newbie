namespace _317_in_out
{
    internal class Progra
    {
        // out修饰的泛型只能作为方法的返回值
        delegate T TestOut<out T>();

        // in修饰的泛型只能作为方法的参数
        delegate void TestIn<in T>(T t);


        public class TestFather
        {

        }

        public class TestSon : TestFather
        {

        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>();


            TestOut<TestSon> testOut = () =>
            {
                return new TestSon();
            };

            TestOut<TestFather> testOutF = testOut;
            TestFather testOutFF = testOutF();

            // in 和 out 只能修饰接口和委托
            //使得具有父子关系的泛型可以相互装载
            //在修饰后使得原本不允许的协

            TestIn<TestFather> testIn = (value) =>
            {

            };

            TestIn<TestSon> iS = testIn;
            iS(new TestSon());

        }
    }
}
