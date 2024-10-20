using System.Collections.Generic;

namespace _310_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LinkedList为双向链表
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            
            // 增
            // 尾部增加
            list1.AddLast(1);
            list1.AddLast(22);
            list1.AddLast(45);
            // 头部增加
            list1.AddFirst(244);
            list1.AddFirst(123);
            list1.AddFirst(11);

            LinkedListNode<int> node1;
            node1 = list1.Find(11);
            // 在之后添加
            list1.AddAfter(node1, 10);
            // 在之前添加
            list1.AddBefore(node1, 19);
            


            // 移除头节点
            list1.RemoveFirst();
            
            // 移除尾节点
            list1.RemoveLast();
            
            // 移除指定节点
            // 无法通过地址移除
            list1.Remove(1);

            // 清空
            //list1.Clear();
            
            
            
            
            // 查询
            LinkedListNode<int> fisrt = list1.First;
            LinkedListNode<int> last = list1.Last;

            // 找到指定节点
            LinkedListNode<int> node;
            node = list1.Find(11);


            // 判断是否存在
            if (list1.Contains(22))
            {
                Console.WriteLine("存在");
            }




            // 修改
            // 要有节点
            list1.First.Value = 2242;
            list1.Last.Value = 0;
            
            LinkedListNode<int> node2 = list1.Find(22);
            node.Value = 0;

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&");
            foreach (int index in list1)
            {
                Console.WriteLine(index);
            }


            Console.WriteLine("&&&&&&&&&&&&&&&&&&&");
            // 从头到尾
            LinkedListNode<int> nowNode;
            nowNode = list1.First;
            while (nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Next;
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&");
            // 从尾到头
            nowNode = list1.Last;
            while (nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Previous;
            }

        }
    }
}
