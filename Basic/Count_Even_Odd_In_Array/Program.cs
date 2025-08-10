public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1, 2, 3, 4, 5];
        
        // Process
        var (evenCount, oddCount) = CountEvenAndOddNumbers(array);
        
        // Output
        Console.WriteLine($"Count of even numbers: {evenCount}");
        Console.WriteLine($"Count of odd numbers: {oddCount}");
    }

    private static (int evenCount, int oddCount) CountEvenAndOddNumbers(int[] array)
    {
        var evenCount = 0;
        var oddCount = 0;

        foreach (var num in array)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        return (evenCount, oddCount);
    }
}