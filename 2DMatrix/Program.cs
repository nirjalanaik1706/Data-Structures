public class Program
{
    
    public static void Display(int[,] matrix)
    {
        for(int i=0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write(matrix [i,j]+" ");
            }
            Console.WriteLine();
        }
    }


    public static void Main(string[] args)
    {
        int[,] semMarks1 =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        int[,] semMarks2=
        {
            {9,8,7},
            {6,5,4},
            {3,2,1}
        };

        Console.WriteLine("\n Sem 1 marks");
        Display(semMarks1);
        Console.WriteLine("\n Sem 2 marks");
        Display(semMarks2);



        // matrix addition
        int[,] totalMarks=new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j=0;j<3;j++)
            {
                totalMarks[i,j]=semMarks1[i,j]+semMarks2[i,j];
            }
        }
        Console.WriteLine("\n Total marks: ");
       Display(totalMarks);


        // Transpose Matrix
        int[,] transposeMatrix=new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                transposeMatrix[i,j]=semMarks1[j,i];
            }
        }
        Console.WriteLine("\n Transpose Matrix");
        Display(transposeMatrix);

        // Diagonal matrix
        int[,] digonalMatrix=new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    digonalMatrix[i,j]=semMarks1[i,j];
                }
                else
                {
                    digonalMatrix[i,j]=0;
                }
            }
        }

        Console.WriteLine("\n Diagnonal Matrix");
        Display(digonalMatrix);


        // Upper rectangual

        int[,]upperRectangular=new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (i <= j)
                {
                    upperRectangular[i,j]=semMarks1[i,j];
                }
                else
                {
                    upperRectangular[i,j]=0;
                }
            }
        }
        Console.WriteLine("\n Upper Rectangular matrix");
        Display(upperRectangular);


        // Lower Rectangular

        int[,]lowerRectangular=new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (i >= j)
                {
                    lowerRectangular[i,j]=semMarks1[i,j];
                }
                else
                {
                    lowerRectangular[i,j]=0;
                }
            }
        }
         Console.WriteLine("\n Lower rectangular");
        Display(lowerRectangular);

        // Matrix Multiplication

        int[,]matrixMultiplication=new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < 3; k++)
                {
                    matrixMultiplication[i,j]+=semMarks1[i,j]*semMarks2[i,j];
                }
            }
        }
        Console.WriteLine("\n Multiplication of matrix");
        Display(matrixMultiplication);
    }

}