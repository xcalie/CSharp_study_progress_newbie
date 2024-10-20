namespace _311_generic_stack_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 多了泛型进行约束，其余一样
            Stack<int> stack = new Stack<int>();
            Queue<int> q = new Queue<int>();
        }
    }
}
