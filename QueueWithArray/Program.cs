using  queuewitharray;

public class Program
{
    public static void Main(string[] args)
    {
        Queue q= new Queue(4);
        q.Enqueue(20);
        q.Enqueue(23);
        q.Enqueue(22);
        q.Enqueue(89);
        q.Peek();
        q.Dequeue();
        q.Peek();
    }
}