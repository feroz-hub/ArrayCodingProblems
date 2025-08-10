public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1, 2, 3, 2, 3, 4, 5];
        
        // Process
        var duplicates = FindDuplicateElements(array);
        
        // Output
        Console.WriteLine($"Duplicate Elements of Array: {string.Join(",",duplicates)}");
    }

    private static int[] FindDuplicateElements(int[] array)
    {
        HashSet<int> seen = [];
        HashSet<int> duplicates = [];
        foreach (var num in array)
        {
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        return duplicates.ToArray();
    }
}