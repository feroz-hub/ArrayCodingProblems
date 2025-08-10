public class Program
{
    private static void Main()
    {
        // Input
        int[] array = [1, 2, 3, 4,5];
        
        const int k = 3; // Number of steps to rotate
        
        // Process
        RotateArray(array, k);
        // Output
        Console.WriteLine("Rotated array: " + string.Join(", ", array));
    }
    
    private static void RotateArray(int[] array, int k)
    {
        const int start = 0;
        var end = array.Length - 1;
        var n = array.Length;
        k= k %= n; // Handle cases where k is greater than n
        
        // Reverse the entire array
        Reverse(array, start, end);
        
        // Reverse the first k elements
        Reverse(array,start ,k - 1);
        
        // Reverse the remaining n-k elements
        Reverse(array,k ,end);
    }
    private static void Reverse(int[] array, int start, int end)
    {
        while (start < end)
        {
            // Swap elements
            (array[start], array[end]) = (array[end], array[start]);
            start++;
            end--;
        }
    }
}