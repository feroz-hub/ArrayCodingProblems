namespace SmallestNumberInArray;

public abstract class Program
{
    private static void Main()
    {
        // Input
        int[] array = [3, 5, 1, 7, 9, 2];
        
        // Process
        var smallestNumberInArray = FindSmallestNumber(array);
        
        // Output
        Console.WriteLine($"Smallest number in the array: {smallestNumberInArray}");
    }

    private static int FindSmallestNumber(int[] array)
    {
        var smallestNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (smallestNumber > array[i])
            {
                smallestNumber = array[i];
            }
            
        }
        return smallestNumber;
        // Alternatively, you can use LINQ to find the smallest number
        // return array.Min();
        // Note: Ensure that the array is not empty before accessing its elements to avoid exceptions.
    }
}