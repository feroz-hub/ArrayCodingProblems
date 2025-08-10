public class Program
{
    static void Main(string[] args)
    {
        // Input
        int[] array = [5,10,7];

        // Process
        var secondSmallestNumber = FindSecondSmallestNumber(array);

        // Output
        Console.WriteLine($"Second smallest number in the array: {secondSmallestNumber}");
    }

    private static int FindSecondSmallestNumber(int[] array)
    {
        var smallestNumber = array[0];
        var secondSmallestNumber = int.MaxValue; // Initialize to the largest possible integer
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < smallestNumber)
            {
                secondSmallestNumber =smallestNumber;
                smallestNumber = array[i];
            }
            else if (array[i] > smallestNumber && array[i] < secondSmallestNumber)
            {
                secondSmallestNumber = array[i];
            }
           
        }
        return secondSmallestNumber;
    }
}