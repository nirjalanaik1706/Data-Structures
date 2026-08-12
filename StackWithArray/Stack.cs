namespace stackwitharray;

public class Stack
{
    int size;
    int current=-1;
    int[] arr;

    public Stack(int size)
    {
        this.size=size;
        arr=new int[size];
    }

    public void Push(int data)
    {
        if (current == size - 1)
        {
            Console.WriteLine("Stack is full");
        }
        current++;
        arr[current]=data;
    }

    public void Pop()
    {
        if (current == -1)
        {
            Console.WriteLine("empty");
        }
        Console.WriteLine("Poping Element: "+arr[current]);
        current--;
    }

    public void Peek()
    {
        if (current == -1)
        {
            Console.WriteLine("empty");
        }
        Console.WriteLine("First Element: "+arr[current]);
    }
}