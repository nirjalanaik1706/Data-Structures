namespace queuewitharray;

public class Queue
{
    int size;
    int front;
    int rear;
    int[] arr;

    public Queue(int size)
    {
        this.size = size;
        arr = new int[size];
        front = 0;
        rear = -1;
    }

    public void Enqueue(int data)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        rear++;
        arr[rear] = data;
    }

    public void Dequeue()
    {
        if (front > rear)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        Console.WriteLine(arr[front]);
        front++;
    }

    public void Peek()
    {
        Console.WriteLine("Front Element: " + arr[front]);
    }


}