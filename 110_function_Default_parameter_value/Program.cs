namespace _110_function_Default_parameter_value
{
    internal class Program
    {
        /*
         * 默认参数值
         * 在没有输入参数时默认初始化
         * 有生命周期和作用域
         * 同理必须滞后
         * 定义默认参数要牢记一点：默认参数必须指向不变对象！
         * 要考虑变长参数和默认参数可能发生的歧义
         */
        static void progress(int number1, int number2 = 100, string str1 ="泥嚎", string str2 = "我测", params int[] array)
        {
            
        }


        static void Main(string[] args)
        {
            
        }
    }
}
