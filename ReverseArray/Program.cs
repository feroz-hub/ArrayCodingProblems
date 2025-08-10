public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1,2,3,4,5,6,7,8,9];
        
        // Process
        ReverseArray(array);
        // Output
        Console.WriteLine("Reversed array: " + string.Join(", ", array));
    }
    // private static void ReverseArray(int[] array)
    // {
    //     var left = 0;
    //     var right = array.Length - 1;
    //
    //     while (left < right)
    //     {
    //         // Swap elements
    //         (array[left], array[right]) = (array[right], array[left]);
    //
    //         // Move towards the middle
    //         left++;
    //         right--;
    //     }
    // }
    
    private static void ReverseArray(int[] array)
    {
        var left = 0;

        while (left < array.Length / 2)
        {
            // Use ^ operator to access elements from the end
            (array[left], array[^ (left + 1)]) = (array[^ (left + 1)], array[left]);

            left++;
        }
    }

}