//C# Program to Print the Lower Bound and Upper Bound of an Array

public class Program
{
    public static void Main(string[] args)
    {
        Array stringArray = Array.CreateInstance(typeof(string), 5);

        stringArray.SetValue("Hello", 0);
        stringArray.SetValue("Hi", 1);
        stringArray.SetValue("Hola",2);
        stringArray.SetValue("Hey",4);

        Console.WriteLine("Lower Bound is {0}",stringArray.GetLowerBound(0));
        Console.WriteLine("Upper Bound is {0}", stringArray.GetUpperBound(0));
    }
}