//C# Program to Reverse an Array

public class Program
{
    public static void Main(string[] aargs)
    {
        int[] arrayA = { 1, 2, 3, 4, 5 };
        int[] arrayR = new int[arrayA.Length];

        for(int i=0;i<arrayA.Length; i++)
        {
            arrayR[i] = arrayA[arrayA.Length - 1 - i];
        }

        Console.WriteLine("Reversed Array: {0}",string.Join("",arrayR));
    }
}