/*
 Search through the array and keep track of minimum value during each iteration. At the end of each iteration, swap variables.
 */

public class SelectionSortAlgorithmApp
{
    public static void Main(string[] args)
    {
        //Creating integer array
        int[] array = { 8, 7, 9, 2, 3, 1, 5, 4, 6 };

        //Sorting array
        SelectionSort(array);

        //Showing sorted array
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    private static void SelectionSort(int[] array)
    {
        //Iterating through array
        for (int i = 0; i < array.Length - 1; i++)
        {           
            int min = i;

            for (int j = i + 1; j<array.Length; j++)
            {
                //For descending order, change the sign to '<'
                if (array[min] > array[j])
                {
                    min = j;
                }
            }

            //Swapping
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }
}