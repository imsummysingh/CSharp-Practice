/*
 C# Program to Print Odd Numbers in a Given Range
 */

public class Program
{
    public static void Main(string[] Args)
    {
        Console.WriteLine("Enter the range to print Odd Number");
        int range = int.Parse(Console.ReadLine());

        for(int i = 1; i <= range; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}