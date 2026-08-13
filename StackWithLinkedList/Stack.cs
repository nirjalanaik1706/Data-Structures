namespace dsa.stack;

using dsa;

public class Stack
{
    Node? top = null;

    public void Push(int data)
    {
        Node newNode = new Node(data);

        newNode.next = top;
        top = newNode;
    }

    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine("Popped: " + top.data);
        top = top.next;
    }

    public void Peek()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine("Top: " + top.data);
    }
}