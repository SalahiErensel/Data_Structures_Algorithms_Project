/* 
Checks if the elements is in order, if not, switches each to make it ordered one by one.
It takes second element to a temporary place, take the second element, place it before the temporary element, and put temporary element to next to it. 
Run time complexity  O(n2) = quadratic. Insertion sort, selection sort, bubble sort 
*/

public class BubbleSortAlgorithmApp
{
    public static void Main(string[] args)
    {
        //Creating integer array unordered
        int[] array = { 5, 3, 8, 4, 2, 7, 1, 6, 9 };

        //Sorting the array
        BubbleSort(array);

        //Showing elements in array ordered
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    private static void BubbleSort(int[] array)
    {
        //Checking each element in array
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                //If the element is bigger than the next element, switch them. This is for ascending order.
                //For descending order, change the sign to '<'
                if (array[j] > array[j + 1])
                {
                    //taking bigger element to a temporary place
                    int temp = array[j];
                    //switching elements
                    array[j] = array[j + 1];
                    //putting temporary element to next to it
                    array[j + 1] = temp;
                }
            }
        } 
    }
}