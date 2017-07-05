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
        }

        public int Data
        {
            get
            {
                return data;
            }
        }

        public SimpleNode(int data)
        {
            next = null;
            this.data = data;
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
