public class Program
{
    private static void Main()
    {
        // Input
        int[] array1 = [1,2,4,5,7,11,12];
        int[] array2 = [3,6,8,9,10];
        // Process
        var mergedArray = MergeSortedArrays(array1, array2);
        // Output
        Console.WriteLine("Merged array: " + string.Join(", ", mergedArray));
    }
    
    private static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        var mergedArray = new int[array1.Length + array2.Length];
        int i = 0, j = 0, k = 0;

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                mergedArray[k++] = array1[i++];
            }
            else
            {
                mergedArray[k++] = array2[j++];
            }
        }

        // Copy remaining elements from array1
        while (i < array1.Length)
        {
            mergedArray[k++] = array1[i++];
        }

        // Copy remaining elements from array2
        while (j < array2.Length)
        {
            mergedArray[k++] = array2[j++];
        }

        return mergedArray;
    }
}