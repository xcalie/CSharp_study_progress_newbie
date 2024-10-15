namespace _218_interface
{

    public interface IFly
    {
        public string Name
        {
            get;
            set;
        }

        //int this[int index]
        //{ 
        //    get;
        //    set;
        //}

        //event Action doSomething;

        //void Fly();
        public void it();
    }

    public interface Walk
    {
        public void it();
    }


    public interface Move : IFly,Walk
    {

    }


    public class Person : Move
    {
        public string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void IFly()
        {

        }

        public void it()
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 遵从里氏替换原则
            Move person = new Person();
            // 显示实现接口
            (person as IFly).it();
            (person as Walk).it();
        }
    }
}
