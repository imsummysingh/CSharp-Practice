//C# Program to Check if a Number is Divisible by 2

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int i = int.Parse(Console.ReadLine());

        if (i % 2 == 0)
        {
            Console.WriteLine("{0} is divisible by 2", i);
        }
        else
        {
            Console.WriteLine("{0} is not divisible by 2",i);
        }
    }
}