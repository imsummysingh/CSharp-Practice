//C# Program to Reverse a Number and Check if it is a Palindrome

public class Program
{
    public static void Main(string[] args)
    {
        int num, temp, remainder;
        int reverse = 0;
        Console.WriteLine("Enter the Number:");
        num = int.Parse(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            remainder = num%10;
            reverse = remainder + reverse*10;
            num = num / 10;
        }

        Console.WriteLine("The reversed number is: {0}", reverse);

        if (temp == reverse)
        {
            Console.WriteLine("This number is also a Palindrome");
        }
        else
        {
            Console.WriteLine("This number is not a Palindrome");
        }
        
    }
}