//Array Rank

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[,] array2 = new int[2, 3];

        Console.WriteLine("The Rank of Array1 i.e. 1D : {0}",array1.Rank);
        Console.WriteLine("The Rank of Array2 i.e. 2D : {0}",array2.Rank);
    }
}