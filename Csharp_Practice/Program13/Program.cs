//C# Program to Reverse a Number

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int num = int.Parse(Console.ReadLine());
        int reverseNo=0;

        while (num != 0)
        {
            reverseNo = reverseNo * 10;
            reverseNo = reverseNo + num % 10;       //this is to keep track for the reverse no
            num=num / 10;
        }

        Console.WriteLine("Reversed No is:",num);

    }
}