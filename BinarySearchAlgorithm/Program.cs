//Finds the position of a target value within sorted array. Half of the array is eliminated during each step
//Always begins at the middle of array

/* 
We check the middle, if the value is found at middle (nearly impossible), we continue. While continuing, we check if the target value is greater than or smaller than the value at the 
middle that we checked. If greater, we eliminate all the elements of array smaller than the middle value and repeat the same process. If smaller, we eliminate all the 
elements of array greater than middle value and repeat the same process until only one element is left which is our target element and return its index. Very efficient for large data sets.
Time complexity is O(log n)
*/

public class BinarySearchApp
{
    public static void Main(string[] args)
    {
        //Creating array of 100 elements
        int[] arr = new int[100];

        //Target value to search
        int target = 42;

        //Populating array with values
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        //Searching for target value
        int index = Array.BinarySearch(arr, target);

        //Custom function to search for target value
        int indexCustom = BinarySearch(arr, target);

        if (indexCustom == -1)
        {
            Console.WriteLine($"Target {target} not found custom function.");
        }
        else
        {
            Console.WriteLine($"Target {target} found special function at index: {indexCustom}");
        }

        if (index == -1)
        {
            Console.WriteLine($"Target {target} not found.");
        }
        else
        {
            Console.WriteLine($"Target {target} found at index: {index}");
        }
    }

    private static int BinarySearch(int[] arr, int target)
    {
        //Starting Point
        int beginning = 0;

        //Ending point
        int end = arr.Length - 1;

        while(beginning <= end)
        {
            //Dividing array into two halves
            int middle = beginning + (end - beginning) / 2;
            int value = arr[middle];

            if (value < target)
            {
                beginning = middle + 1;
            }
            else if(value > target)
            {
                end = middle - 1;
            }
            //Target found
            else
            {
                return middle;
            }
        }
        //Target not found
        return -1;
    }
}