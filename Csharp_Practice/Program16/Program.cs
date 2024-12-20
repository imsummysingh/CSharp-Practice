//C# Program to Find the Length of an Array

public class Program
{
    public static void Main(string[] args)
    {
        int[] arrayA = new int[5];
        int[,] arrayB = new int[5,10];

        Console.WriteLine("The length of Array A is: {0}", arrayA.Length);
        Console.WriteLine("The length of Array B i.e. 2D is: {0}",arrayB.Length);
    }
}