public class Program
{
    static void Main(string[] args)
    {
        //input
        int[] array = [1, 2, 3, 4, 5];
        
        //process
        var lengthOfArray = FindArrayLength(array);
        
        //output
        Console.WriteLine($"Length of the array :{lengthOfArray}");
        
    }

    private static int FindArrayLength(int[] array)
    {
        return array.Length == 0 ? 0 : array.Length;
    }
}