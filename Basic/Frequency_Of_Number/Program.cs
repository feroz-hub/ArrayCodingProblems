public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1, 3, 2, 3, 2, 4, 5, 2];
        int numberToFind = 2;
        
        // Process
        var frequency = FindFrequencyOfNumber(array, numberToFind);
        
        // Output
        Console.WriteLine($"Frequency of {numberToFind} in the array: {frequency}");
        
    }

    private static int FindFrequencyOfNumber(int[] array, int numberToFind)
    {
        var count = 0;
        foreach (var num in array)
        {
            if (num == numberToFind)
            {
                count++;
            }
            
        }
        return count;
        // Alternatively, you can use LINQ to find the frequency
        // return array.Count(num => num == numberToFind);
    }
}