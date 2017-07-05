using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleNode root = new SimpleNode(1);

            root.AppendNode(1);
            root.AppendNode(2);
            root.AppendNode(3);
            root.AppendNode(5);
            root.AppendNode(8);
            root.AppendNode(13);
            root.AppendNode(21);

            SimpleNode pointer = root;

            while (pointer != null)
            {
                Console.WriteLine(pointer.Data);
                pointer = pointer.Next;
            }

            Console.Read();
        }
    }
}
