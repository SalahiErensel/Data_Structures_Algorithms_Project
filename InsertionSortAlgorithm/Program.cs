/*
After comparing elements to the left, shift elements to the right to make a room to insert a value.
Run time complexity = O(n2).
Goo for small data sets, bad for large data sets. Less steps than bubble sort, best case is O(n) compared to Selection Sort O(n2)
*/

public class InsertionSortAlgorithmApp
{
    public static void Main(string[] args)
    {
        //Creating integer array
        int[] array = { 8, 7, 9, 2, 3, 1, 5, 4, 6 };

        //Sorting array
        InsertionSort(array);

        //Showing sorted array
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    private static void InsertionSort(int[] array)
    {
        for(int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = temp;
        }
    }
}