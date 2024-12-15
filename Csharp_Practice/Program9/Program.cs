//C# Program to Find the Sum of All the Multiples of 3 and 5

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("the Sum of All the Multiples of 3 and 5 for first 100 numbers");

        int sum = 0;

        for(int i = 0; i < 100; i++)
        {
            if(i%3==0 || i % 5 == 0)
            {
                sum=sum+i;
            }
        }
        Console.WriteLine(sum);
    }
}