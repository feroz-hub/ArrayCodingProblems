public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1, 2, 3, 1, 1, 4, 5, 3, 4];
        
        // Process
        var uniqueElements = GetUniqueElements(array);
        // Output
        Console.WriteLine("Unique elements in the array: " + string.Join(", ", uniqueElements));
    }
    private static int[] GetUniqueElements(int[] array)
    {
        // Use a HashSet to store unique elements
        var uniqueElements = new HashSet<int>(array);
        
        // Convert HashSet back to array
        return uniqueElements.ToArray();
        
        // Alternatively, you can use LINQ to get unique elements
        // return array.Distinct().ToArray();
        // Alternatively, you can use a List to collect unique elements
        // var uniqueElements = new List<int>();
        // foreach (var num in array)
        // {
        //     if (!uniqueElements.Contains(num))
        //     {
        //         uniqueElements.Add(num);
        //     }
        // }
        // return uniqueElements.ToArray();
        
    }
}