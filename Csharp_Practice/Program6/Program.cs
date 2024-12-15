//C# Program to Find the Largest of Two Numbers

public class Program
{
    public static void Main(string[] Args)
    {
        Console.WriteLine("Enter the two numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("{0} is greater", a);
        }
        else
        {
            Console.WriteLine("{0} is greater", b);
        }
    }
}