public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [3,5,7,9,11];
        
        // Process
        double averageOfArray = CalculateAverage(array);
        
        // Output
        Console.WriteLine($"Average of the array: {averageOfArray}");
    }

    private static double CalculateAverage(int[] array)
    {
        // Assume 0 as the initial sum value
        int sum = 0;
        // Iterate through each element in the array and add it to the sum
        if (array.Length == 0)
        {
            return 0; // Return 0 if the array is null or empty
        }

        foreach (var num in array)
        {
            sum += num;
        }
        // Calculate the average by dividing the sum by the number of elements
        var average = (double)sum / array.Length;
        return average;
        // Alternatively, you can use LINQ to calculate the average
        // return array.Average();
        
    }
}