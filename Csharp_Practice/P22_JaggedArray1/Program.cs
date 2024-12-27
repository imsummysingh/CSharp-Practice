//Jagged Array

public class Program
{
    public static void Main(string[] args)
    {
        int[][] jArray = new int[3][];
        jArray[0] = new int[2];
        jArray[0][0] = 11;
        jArray[0][1] = 12;

        jArray[1] = new int[1] { 13 };
        jArray[2] = new int[2] { 14, 15 };

        //row is the length
        //column we push to newInnerArray

        for (int i = 0; i < jArray.Length; i++)
        {
            int[] innerArray = jArray[i];
            for(int j=0;j<innerArray.Length; j++)
            {
                Console.WriteLine(innerArray[j]+" ");   //11 12 13 14 15
            }
        }
    }
}