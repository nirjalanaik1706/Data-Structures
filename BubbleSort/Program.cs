public class BubbleSort{

    public void Sort(int[] arr){
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                int temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] arr={10,20,27,1,6};

        BubbleSort b=new BubbleSort();
        b.Sort(arr);
        for(int i=0;i<arr.Length;i++){
        Console.WriteLine(arr[i]+",");
        }
    }
}