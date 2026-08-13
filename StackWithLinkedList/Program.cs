using dsa;
using dsa.stack;
public class Program
{
    public static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(89);
        stack.Push(30);
        stack.Push(9);
        stack.Push(70);
        stack.Push(8);
        stack.Pop();
        stack.Peek();

    }
}
