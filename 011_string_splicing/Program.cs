namespace _011_string_splicing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 普通字符串拼接

            string str = "123";
            Console.WriteLine(str);

            str += "4456";
            Console.WriteLine(str);

            str = "1233" + 1 + 23 + 'A';
            Console.WriteLine(str);

            str = "1233" + 1 + 23 + 'A' + true;
            Console.WriteLine(str);

            #endregion

            #region format字符串拼接

            string str2 = string.Format("我阐述你的梦");
            Console.WriteLine(str2);

            Console.WriteLine("{0}我是{1}个{2}", "全体目光向我看齐", 1, "傻逼");

            #endregion
        }
    }
}
