//C# Program to Swap Two Numbers

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the values of two number to Swap");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int temp;
        temp = a;   //assigning a to temp, now a is empty
        a = b;      //assigning b value to a
        b = temp;   //assigning temp value to b

        Console.WriteLine("The two values after swapping are:");
        Console.WriteLine("a:{0} & b:{1}", a, b);

    }
}