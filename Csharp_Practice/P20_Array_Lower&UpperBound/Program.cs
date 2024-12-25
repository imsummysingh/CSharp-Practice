//C# Program to Print the Lower Bound and Upper Bound of an Array

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 10,99 };

        Console.WriteLine("Lower Bound of Array: {0}", arr.GetLowerBound(0));   //0

        Console.WriteLine("Upper Bound of Array: {0}",arr.GetUpperBound(0));    //7
    }
}