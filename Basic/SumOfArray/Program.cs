namespace SumOfArray;

public static class Program
{
    private static void Main()
    {
        // Input
        int[] array = [2,5,4,2,6,7,8,9,10,11];
        
        // Process
        var sumOfArray = CalculateSum(array);
        
        // Output
        Console.WriteLine($"Sum of the array: {sumOfArray}");
        
    }

    private static int CalculateSum(int[] array)
    {
        // Assume 0 as the initial sum value
        var sum = 0;
        
        // Iterate through each element in the array and add it to the sum
        if (array.Length == 0)
        {
            return 0; // Return 0 if the array is null or empty
        }
        foreach (var t in array)
        {
            sum += t;
        }

        return sum;
        
        // Alternatively, you can use LINQ to calculate the sum
        // return array.Sum();
    }
}