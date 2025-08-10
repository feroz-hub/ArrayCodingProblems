public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [4,2,5,8,1,9,3];
        
        // Process
        var largestNumberInArray = FindLargestNumber(array);
        
        // Output
        Console.WriteLine($"Largest number in the array: {largestNumberInArray}");
    }

    private static int FindLargestNumber(int[] array)
    {
        var largestNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (largestNumber < array[i])
            {
                largestNumber = array[i];
            }

            

        }
        return largestNumber;
        // Alternatively, you can use LINQ to find the largest number
        // return array.Max();
    }
}