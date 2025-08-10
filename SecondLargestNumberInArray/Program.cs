public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [10,7,23,45,30];
        
        // Process
        var secondLargestNumber = FindSecondLargestNumber(array);
        
        // Output
        Console.WriteLine($"Second largest number in the array: {secondLargestNumber}");
    }

    private static int FindSecondLargestNumber(int[] array)
    {
        var largestNumber = array[0];
        var secondLargestNumber = int.MinValue; // Initialize to the smallest possible integer
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > largestNumber)
            {
                secondLargestNumber = largestNumber;
                largestNumber= array[i];
            }
            else if(array[i] > secondLargestNumber &&  array[i] != largestNumber)
            {
                secondLargestNumber = array[i];
            }
            
        }
        return secondLargestNumber;
    }
}