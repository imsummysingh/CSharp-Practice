//C# Program to Find Sum of Digits of a Number using Recursion

public class SumOfDigit
{
    public int sum(int num)
    {
        int rem, sum = 0;
        while (num != 0)
        {
            rem = num % 10;
            num = num / 10;
            sum = sum + rem;
        }
        return sum;
    }
}

public class Program
{    

    public static void Main(string[] args)
    {
        SumOfDigit sum = new SumOfDigit();
        Console.WriteLine("Enter the number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum is {0}",sum.sum(num));
    }

    
}