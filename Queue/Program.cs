using NodeLinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        Queue q = new Queue();
        q.insert(20);
        q.insert(30);
        q.insert(40);
        q.insert(10);
        q.insert(90);
        q.Display();
        Console.WriteLine();
        q.delete(10);
        q.Display();

    }
}