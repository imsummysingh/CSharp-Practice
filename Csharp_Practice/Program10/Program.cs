//C# Program to Print All the Multiples of 17 which are Less than 100

public class Program
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 100; i++)
        {
            if (i % 17 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}