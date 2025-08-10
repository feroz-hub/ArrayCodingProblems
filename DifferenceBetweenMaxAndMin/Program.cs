public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1, 2, 3];
        
        // Process
        var difference = FindDifferenceBetweenMaxAndMin(array);
        
        // Output
        Console.WriteLine($"Difference between the largest and smallest number in the array: {difference}");
    }

    private static int FindDifferenceBetweenMaxAndMin(int[] array)
    {
        var largestNumber = array[0];
        var smallestNumber = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            var num = array[i];
            if(num >largestNumber)
            {
                largestNumber = num;
            }
            if(num < smallestNumber)
            {
                smallestNumber = num;
            }
            
        }
        var difference = largestNumber - smallestNumber;
        return difference;
        //return array.Max() - array.Min();
    }
}