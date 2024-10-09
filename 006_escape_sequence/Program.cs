namespace _006_escape_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 转义序列
            string str = "Hallo\nWorld";
            Console.WriteLine(str);

            string str1 = "Hallogg\rWorld";
            Console.WriteLine(str1);
            // \r 会回到开头并覆盖

            string str2 = "hallo\\world";
            Console.WriteLine(str2);

            string str3 = "hallo\tworld";
            Console.WriteLine(str3);

            string str4 = "123\b456";
            Console.WriteLine(str4);

            string str5 = "123\0456";
            Console.WriteLine(str5);

            string str6 = "123\a456";
            Console.WriteLine(str6);
            #endregion

            #region 取消转义序列

            Console.WriteLine(@"asdlknv\asdnxl");
            // 这里将不会对 \ 进行转义序列转换

            #endregion
        }
    }
}
