/*C# Program to Check Whether a Number is Positive or Not*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int i = int.Parse(Console.ReadLine());

        if (i >= 0)
        {
            Console.WriteLine("It is a positive number");
        }
        else
        {
            Console.WriteLine("It is a negative number");
        }
    }
}