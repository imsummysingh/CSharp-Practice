//C# Program to Search an Element in an Array

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < array1.Length; i++)
        {
            if (n == array1[i])
            {
                Console.WriteLine("Element is available and at: {0} index",i);
            }
        }
        Console.WriteLine("Element does not exist");
    }
}