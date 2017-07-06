namespace Fundamentals
{
    public class SimpleNode
    {
        int data;
        SimpleNode next;

        public SimpleNode Next
        {
            get
            {
                return next;
            }
            internal set
            {
                next = this;
            }
        }

        public int Data
        {
            get
            {
                return data;
            }
        }

        public SimpleNode()
        {
            next = null;
            data = default(int);
        }
        public SimpleNode(int data)
        {
            this.data = data;
            next = null;
        }

        public void AppendNode(int data)
        {
            SimpleNode tail = new SimpleNode(data);
            SimpleNode n = this;

            while (n.next != null)
                n = n.next;

            n.next = tail;
        }
    }
}
