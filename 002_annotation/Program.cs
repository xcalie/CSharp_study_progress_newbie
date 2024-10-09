
using System;

namespace _002_annotation
{
    /// <summary>
    /// 这是作用大段注释
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 这个注释可以收齐，在最后发布的时候不会出现在正式代码中

            // Console.WriteLine("Hello, World!");

            /*
             * 
             * 
             *          这是一段注释 
             *      ctrl + k 注释
             *      crrl + u 取消注释
             * 
             */

            #endregion
        }
    }
}
