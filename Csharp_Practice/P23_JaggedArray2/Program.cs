//Jagged Array 2

public class Program
{
    public static void Main(string[] args)
    {
        byte[][] jArray = new byte[3][];

        for(int i = 0; i < jArray.Length; i++)
        {
            jArray[i] = new byte[i + 3];
        }

        for(int i=0;i<jArray.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, jArray[i].Length);
        }
    }
}