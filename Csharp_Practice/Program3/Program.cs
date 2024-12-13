/*C# Program to Check Whether a Given Number is Even or Odd*/


public class Program
{
    public static void Main(string[] Args)
    {
        int i;
        Console.WriteLine("Enter a Number:");
        i = int.Parse(Console.ReadLine());

        if (i % 2 == 0)
        {
            Console.WriteLine("The given number is Even");
        }
        else
        {
            Console.WriteLine("The given number is Odd");
        }
    }
}