public class Program
{
    static void Main()
    {
        // Input
        int[] array = [1, 2, 3, 2, 3, 4, 2, 3, 5];
        
        // Process
        var uniqueArray = RemoveDuplicates(array);
        
        // Output
        Console.WriteLine("Array after removing duplicates: " + string.Join(", ", uniqueArray));
    }

    private static int[] RemoveDuplicates(int[] array)
    {
        //var uniqueElements = new HashSet<int>(array);
        // Alternatively, you can use a List to collect unique elements
        var uniqueElements = new List<int>();
        foreach (var num in array)
        {
            if (!uniqueElements.Contains(num))
            {
                uniqueElements.Add(num);
            }
        }
        //Convert HashSet back to array
         return uniqueElements.ToArray();
         
        // Alternatively, you can use LINQ to remove duplicates
        // return array.Distinct().ToArray();
    }
}