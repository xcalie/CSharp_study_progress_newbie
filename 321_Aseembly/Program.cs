using System.Reflection;

namespace _321_Aseembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 加载程序集
            Assembly assembly = Assembly.LoadFrom("E:\\vs_saver\\repoes\\CSharp_study_progress_newbie\\320_Type\\obj\\Debug\\net8.0\\320_Type");
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
            }


            // 获取程序集的对象
            Type ?icon = assembly.GetType("320_Type.icon");
            MemberInfo[] members = icon.GetMembers();
            
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i].Name);
            }
            
        }
    }
}
