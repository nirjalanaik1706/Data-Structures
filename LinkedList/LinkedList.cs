namespace tflDsa;
using dsa;
public class LinkedList{
    Node head=null;
    public  void Display()
    {
        Node current=head;
        while (current != null){
            Console.Write(current.data+"--->");
            current=current.next;
        }
    }

    public void Insert(int data)
    {   
        Node newData=new Node(data);
        if (head == null){
            head=newData;
        }
        else{
            Node current=head;
            while(current.next!=null){
            current=current.next;
            }
            current.next=newData;
        }
    }

    public void Delete(int data)
    {
        if (head.data == data){
            if (head.next == null)
            {
                head=null;
            }
            else{
            head=head.next;
        }
        }
        else{
            Node current=head;
            while (current.next.data != data)
            {
            current=current.next;
            }
            if(current.next.next==null){
                current.next=null;
            }
            else{
            current.next=current.next.next;
            }
        }
    }

    public void Update(int oldData,int newData)
    {
        if ( head.data== oldData){
            head.data=newData;
        }
        else{
            Node current=head;
            while (current.data != oldData){
                current=current.next;
            }
            current.data=newData;
        }
        
    }
}
