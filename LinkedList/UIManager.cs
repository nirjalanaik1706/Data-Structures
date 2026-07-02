namespace manager;

using tflDsa;
public class UIManager
{

    LinkedList list = new LinkedList();
    public void show()
    {
        while(true){   
        Console.WriteLine("\n=========================");
        Console.WriteLine("!!!----LINKED LIST----!!!");
        Console.WriteLine("=========================");
        Console.WriteLine("1. Insert Node: ");
        Console.WriteLine("2. Display Linked List: ");
        Console.WriteLine("3. Update Node: ");
        Console.WriteLine("4. Delete Node : ");
        Console.WriteLine("5. Exit");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Enter Your Choice: ");
        int choice = int.Parse(Console.ReadLine());
        HandleDisplayMenu(choice);
        }
    }

    public void HandleDisplayMenu(int num)
    {
       
            switch (num)
            {
                case 1:
                    Console.Write("How many elements do you want to insert? ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write($"Enter data {i}: ");
                        int data = int.Parse(Console.ReadLine());
                        list.Insert(data);
                    }
                    Console.WriteLine("\nList after insertion:");
                    list.Display();
                    break;


                case 2:
                    Console.WriteLine("\nLinked list : ");
                    list.Display();
                    break;

                case 3:
                    Console.WriteLine("Update Node:");
                    list.Display();
                    Console.WriteLine("\nEnter Old data :");
                    int oldData = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter new data: ");
                    int newData = int.Parse(Console.ReadLine());
                    list.Update(oldData, newData);
                    Console.WriteLine("\nYour updated Linked List: ");
                    list.Display();
                    break;

                case 4:
                    list.Display();
                    Console.WriteLine("\nEnter value to delete");
                    int toDelete = int.Parse(Console.ReadLine());
                    list.Delete(toDelete);
                    Console.WriteLine("\nYour Linked list : ");
                    list.Display();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }




