namespace _008_explicit_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 括号强制转换

            // 强制转换会导致范围溢出，尝试进行转换

            Int16 int16_1 = 1;
            Int32 int32_1 = 2;

            int16_1 = (Int16)int32_1;
            // 发生强制转换

            float float_1 = 1.22f;

            int32_1 = (Int32)float_1;
            // 强制转换会丢弃浮点后部分

            Int32 int32_2 = 'A';
            char c = (char)int32_2;
            Console.WriteLine(c);


            /*
             *      bool 也不参与强制转换
             *      string 同理
             */
            #endregion

            #region Parse字符串转为对应类型

            // 字符串转为对应类型
            // 必须能够转

            Int32 int32_3 = Int32.Parse("123");
            Console.WriteLine(int32_3);

            UInt32 Uint32_3 = UInt32.Parse("123");
            Console.WriteLine(Uint32_3);
            // 必须复合变量的范围

            float float_3 = float.Parse("123.12");
            Console.WriteLine(float_3);

            Console.WriteLine(sbyte.Parse("1"));

            bool bool_3 = bool.Parse("true");
            Console.WriteLine(bool_3);

            char char_3 = char.Parse("A");
            Console.WriteLine(char_3);

            #endregion

            #region convert类型转换为字符串

            Int32 a = Convert.ToInt32("12");
            Console.WriteLine(a);

            a = Convert.ToInt32(1.23234434f);
            Console.WriteLine(a);
            // 会四舍五入，不会舍弃

            a = Convert.ToInt32(true);
            Console.WriteLine(a);

            a = Convert.ToInt32('A');
            Console.WriteLine(a);

            #endregion

            #region 其他类型转为字符串

            string str = 1.ToString();
            Console.WriteLine(str);
            str =  true.ToString();
            Console.WriteLine(str);
            str = 'A'.ToString();
            Console.WriteLine(str);
            str = 1.2f.ToString();
            Console.WriteLine(str);

            Int32 aa = 123123;
            str = aa.ToString();
            Console.WriteLine(str);

            Console.WriteLine("123231" + 1 + true + 1.1f);


            #endregion
        }
    }
}
