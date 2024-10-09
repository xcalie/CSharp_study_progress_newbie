namespace _007_implicit_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 普通隐式转换尽量避免

            long long1 = 1;
            int int1 = 1;
            short short1 = 1;
            sbyte sbyte1 = 1;

            long1 = int1;
            long1 = short1;
            long1 = sbyte1;

            // int1 = long1; 不能小转大


            #endregion


            #region 不同类型的转换

            int int2 = 1;
            float float2 = 1.1f;

            float2 = int2;
            // 整形可以向浮点数转换，但浮点数不能像整形转换

            //int2 = float2;

            /*
             *      bool string
             *      不能隐式转换
             *      
             *      char 本质为 int8
             *      遵从大转小
             */

            #endregion

            // double -> float -> 整形u/d -> char
            // decimal -> 整形 -> char

        }
    }
}
