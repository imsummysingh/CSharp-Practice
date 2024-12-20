////C# Program to Search an Element or contain the element in an Array

public class Program
{
    public static void Main(string[] args)
    {
        string[] array1 = { "Hello", "Hey", "Damn", "ByeByeHello" };

        string v1 = Array.Find(array1,e=>e.StartsWith("Bye",StringComparison.Ordinal));

        string v2 = Array.Find(array1, e => e.Length == 3);

        Console.WriteLine("The element that starts with Bye :{0}", v1);

        Console.WriteLine("The element with length 3 is :{0}",v2);

        Console.ReadLine();
    }
}