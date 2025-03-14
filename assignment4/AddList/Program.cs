using System;
namespace GenericApplication
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
            for (Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            for (Node<int> node = intlist.Head;
                  node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            intlist.ForEach(data => Console.WriteLine(data));  //调用ForEach打印链表元素

            int max = int.MinValue;     //求最大值
            intlist.ForEach(data =>
            {
                if (data > max)
                    max = data;
            });
            Console.WriteLine($"最大值: {max}");

            int min = int.MaxValue;     //求最小值
            intlist.ForEach(data =>
            {
                if (data < min)
                    min = data;
            });
            Console.WriteLine($"最小值: {min}");

            int sum = 0;                //求和
            intlist.ForEach(data => sum += data);
            Console.WriteLine($"和: {sum}");


            // 字符串型List
            //GenericList<string> strList = new GenericList<string>();
            //for (int x = 0; x < 10; x++)
            //{
            //    strList.Add("str" + x);
            //}
            //for (Node<string> node = strList.Head;
            //        node != null; node = node.Next)
            //{
            //    Console.WriteLine(node.Data);
            //}

           
        }

    }
}
