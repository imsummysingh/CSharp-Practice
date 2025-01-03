//C# Program to Sort a List of Names in Alphabetical Order

public class Program
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Ranjeet");
        list.Add("Abhishek");
        list.Add("Summy");

        list.Sort();

        foreach (string item in list)

        Console.WriteLine(item);
    }
}