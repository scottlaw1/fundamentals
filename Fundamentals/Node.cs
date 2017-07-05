namespace Fundamentals
{
    public class Node
    {
        int data;

        Node previous;
        Node next;

        public int Data
        {
            get
            {
                return data;
            }
        }
        public Node Next
        {
            get
            {
                return next;
            }
        }

        public Node Previous
        {
            get
            {
                return previous;
            }
        }

        public Node(int data)
        {
            next = null;
            previous = null;
            this.data = data;
        }

        public void AppendNode(int data)
        {
            Node tail = new Node(data);
            Node n = this;

            while (n.next != null)
                n = n.next;

            n.next = tail;
        }
    }
}
