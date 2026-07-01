public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data=data;
    }

    public static void Main(string[] args)
    {
        Node head=new Node(10);
        Node p=head;
        Node first=new Node(29);
        Node second=new Node(6);
        Node third=new Node(58);
        Node forth=new Node(30);
        
        p.next=first;
        p=p.next;
        p.next=second;
        Node r=p.next;
        r.next=third;
        Node s=r.next;
        s.next=forth;

        Node q=head;

        while (q != null)
        {
            Console.Write(q.data+"--->");
            q=q.next;
        }
    }
}