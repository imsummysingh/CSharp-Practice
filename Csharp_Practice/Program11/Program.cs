//Sum of Digits Program in C#

public class Program
{
    public static void Main(string[] args)
    {
        int num;
        int sum = 0;
        int rem = 0;

        Console.WriteLine("Enter the Number:");
        num=int.Parse(Console.ReadLine());

        while (num != 0)
        {
            rem = num % 10;
            num = num / 10;
            sum = sum + rem;
        }

        Console.WriteLine("The sum is {0}:",sum);

    }
}
