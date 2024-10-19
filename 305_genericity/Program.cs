namespace _305_genericity
{
    internal class Program
    {
        interface Fly<FlyA, FlyB, FlyC>
        {
            FlyA Number1
            {
                get;
                set;
            }

            FlyB Number2
            {
                get;
                set;
            }
            FlyC Number3
            {
                get;
                set;
            }
        }
        class Test<TestA, TestB, TestC> : Fly<int, int, float>
        {
            public TestA object1;
            public TestB object2;
            public TestC object3;

            

            public int Number1
            {
                get;
                set;
            }
            public int Number2
            {
                get;
                set;
            }
            public float Number3
            {
                get;
                set;
            }

            public Test (TestA testA, TestB testB, TestC testC,int number1, int number2,  float number3)
            {
                
                this.object1 = testA;
                this.object2 = testB;
                this.object3 = testC;
            }
        }

        class ArrayList<T>
        {
            public T[] numbers;

            public ArrayList()
            {
                numbers = new T[10];
            }

            public void Add(T number1)
            {

            }
        }

        static void Main(string[] args)
        {
            Test<int, string, float> test = new Test<int, string, float> (12 , "2134", 2.4f, 1223, 3133, 23.1f);
            test.object1 = 10;
            test.object2 = "string";
            test.object3 = 2.2f;
            
            
        }
    }
}
