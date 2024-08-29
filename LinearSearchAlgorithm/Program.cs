//Run Time Complexity --> O(n)
//Slow for large data sets, fast for small to medium data sets
//Doesnt need to be sorted
//Useful for data structures with no random access(Linked Lists)

public class LinearSearchApp
{
    public static void Main(string[] args)
    {
        //creating integer array
        int[] array = [9, 1, 8, 2, 7, 3, 4, 6, 5];

        //Searching for 6 in the array to return its index which is 7
        int existingIndex = LinearSearch(array, 7);

        //Searching for 17 in the array which not exist in the array so it will return -1
        int notExistingIndex = LinearSearch(array, 17);

        Console.WriteLine($"Index for target 6 is: {existingIndex}");

        Console.WriteLine($"\nIndex for target 17 is: {notExistingIndex}");
    }

    public static int LinearSearch(int[] array, int target)
    {
        //Looping through the array to find the target
        for (int i = 0; i < array.Length; i++)
        {
            //Target found
            if (array[i] == target)
            {
                //Return the index of the target
                return i;
            }
        }
        //Target not found  
        return -1;
    }
}