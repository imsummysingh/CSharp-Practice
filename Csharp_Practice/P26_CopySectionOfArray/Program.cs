//Copy Section Of Array to Another Array

public class Program
{
    public static void Main()
    {
        int n, m, size;

        Console.WriteLine("Enter the size of Array1");
        n=Convert.ToInt32(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Enter the elements in the Array: ");
        for(int i = 0; i < n; i++)
        {
            a[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the size of Array2");
        m= Convert.ToInt32(Console.ReadLine());

        int[] b = new int[m];

        Console.WriteLine("Enter the position to copy:");
        size = Convert.ToInt32(Console.ReadLine());

        Array.Copy(a,0,b,0,size);

        Console.WriteLine("The new array after copying");

        foreach(int i in b)
        {
            Console.WriteLine(i);
        }

    }
}