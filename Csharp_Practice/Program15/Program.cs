//C# Program to Perform All Arithmetic Operations

public class Program
{
    public static void Main(string[] args)
    {
        int result; 

        Console.WriteLine("Please enter the number 1");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number 2");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The operation we perform:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Substraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("The sum of num1 & num2 is: {0}", result);
                break;

            case 2:
                result = num1 - num2;
                Console.WriteLine("The substraction of num1 & num2 is: {0}", result);
                break;

            case 3:
                result = num1 * num2;
                Console.WriteLine("The multiplication of num1 & num2 is: {0}", result);
                break;

            case 4:
                result = num1 / num2;
                Console.WriteLine("The division of num1 & num2 is: {0}", result);
                break;

            default:
                Console.WriteLine("Invalid Operation Selected");
                break;  
        }
    }
}