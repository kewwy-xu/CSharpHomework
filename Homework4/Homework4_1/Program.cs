using System;

namespace Homework4_1
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> t = this.head;
            while(t!=null)
            {
                action(t.Data);
                t = t.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> aList = new GenericList<int>();
            for(int i=0;i<10;i++)
            {
                aList.Add(i);
            }
            //打印每个链表元素
            aList.ForEach(m => Console.WriteLine(m));
            //求最大值
            int max = aList.Head.Data;
            aList.ForEach(m => { if (max < m) max = m; });
            Console.WriteLine("最大值为：" + max);
            //求最小值
            int min = aList.Head.Data;
            aList.ForEach(m => { if (min > m) min = m; });
            Console.WriteLine("最小值为：" + min);
            //求和
            int sum = 0;
            aList.ForEach(m => sum += m);
            Console.WriteLine("和为：" + sum);
        }
    }
}
