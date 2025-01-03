//C# Program to Convert a 2D Array into 1D Array

public class Program
{
    int m, n;
    int[,] a;
    int[] b;

    public Program(int x, int y)    //constructor 
    {
        m = x;
        n = y;
        a = new int[x, y];
        b = new int[x * y];
    }

    public void readMatrix()
    {
        for(int i = 0; i < m; i++)
        {
            for(int j=0; j < n; j++)
            {
                Console.WriteLine("a[{0},{1}]",i,j);
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public void print2D()
    {
        for(int i = 0;i < m; i++)
        {
            for (int j=0; j < n; j++)
            {
                Console.Write("{0}\t",a[i,j]);
            }
            Console.WriteLine();
        }
    }

    public void convertArray()
    {
        int k = 0;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                b[k++] = a[i, j];
            }
        }
    }

    public void print1D()
    {
        for(int i = 0; i < m * n; i++)
        {
            Console.WriteLine("{0}\t", b[i]);
        }
    }

    public static void Main(string[] args)
    {
        Program p = new Program(2,3);

        Console.WriteLine("Enter the Elements : ");
        p.readMatrix();
        Console.WriteLine("Given 2-D Array(Matrix) is : ");
        p.print2D();
        p.convertArray();
        Console.WriteLine("Converted 1-D Array is : ");
        p.print1D();
        Console.ReadLine();
    }
}