namespace NodeLinkedList
{

    internal class Queue
    {
        Node rear;
        Node front;

        public void insert(int newData)
        {
            Node data = new Node(newData);
            if (rear == null)
            {
                rear = data;
                front = rear;
            }
            else
            {
                rear.next = data;
                rear = rear.next;
            }
        }

        public void delete(int data)
        {
            Node deleteNode = new Node(data);
            if (front == null)
            {
                return;
            }
            else
            {
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }
            }
        }

        public void Display()
        {
            Node current = front;
            while (current != null)
            {
                Console.Write(current.data + "<---");
                current = current.next;
            }
        }
    }
}