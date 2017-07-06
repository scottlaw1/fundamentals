using System;

namespace Fundamentals
{
    public class SimpleStack
    {
        SimpleNode top;

        public SimpleStack()
        {
            top = new SimpleNode();
        }
        public void Push(int item)
        {
            SimpleNode sn = new SimpleNode(item);

            top.Next = top;
            top = sn;
        }

        public int Pop()
        {
            if (top == null||(top.Next == null && top.Data==default(int)))
                throw new InvalidOperationException("Popping an empty stack is not allowed.");

            SimpleNode sn = top;
            top = top.Next;

            return sn.Data;
        }

        public int Peek()
        {
            if (top == null || (top.Next == null && top.Data == default(int)))
                throw new InvalidOperationException("Peek on an empty stack is not allowed.");

            return top.Data;
        }
    }
}
