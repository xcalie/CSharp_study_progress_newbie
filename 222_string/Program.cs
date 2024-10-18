namespace _222_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 字符很多操作符将返回一个新的字符串，需要赋值接受

            #region 访问

            string str = "卧槽";
            Console.WriteLine(str[1]);

            char[] arr = str.ToCharArray();
            Console.WriteLine(arr[1]);

            #endregion

            #region 拼接
            str = string.Format("{0}{1}", 123, 534);
            Console.WriteLine(str);
            Console.WriteLine("123" + 3213 + str);
            #endregion

            #region 正向查找

            str = "我是个傻逼傻逼";
            int index = str.IndexOf("是");
            Console.WriteLine(index);

            index = str.IndexOf("吊");
            Console.WriteLine(index);

            #endregion

            #region 反向查找

            index = str.LastIndexOf("傻逼");
            Console.WriteLine(index);

            index = str.LastIndexOf("傻逼傻");
            Console.WriteLine(index);

            #endregion

            #region 移除

            str = "12345678";
            // 从指定位置往后移除
            str.Remove(2);
            Console.WriteLine(str);

            // 返回值是新建立的字符串,需要赋值接受 
            str = str.Remove(2);
            Console.WriteLine(str);


            str = "12345678";

            str = str.Remove(1, 2);
            Console.WriteLine(str);

            #endregion

            #region 替换

            str = "我是个傻逼傻逼";
            str = str.Replace("傻逼", "老残");
            Console.WriteLine(str);

            #endregion

            #region 大小写转换

            str = "asjdflksdfjSALSKJDLAklasjflkvn";
            str = str.ToUpper();
            Console.WriteLine(str);

            str = str.ToLower();
            Console.WriteLine(str);

            #endregion

            #region 字符串截取

            // 返回被截取的字符串
            str = "我是个傻逼！！";

            str = str.Substring(2);
            Console.WriteLine(str);

            // 从第n个截取
            str = "我是个傻逼！！";
            str = str.Substring(2, 1);
            Console.WriteLine(str);

            #endregion

            #region 字符串截取

            str = "1,2,3,4,2321,43,33";
            string[] strs = str.Split(',');
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }


            #endregion
        }
    }
}
