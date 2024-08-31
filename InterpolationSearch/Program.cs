/* Improvement over binary search best used for uniformly distributed guesses where a value may be based on calculated probe results. If probe is incorrect, search area is narrowed.
Average case: O(log(log n))
Worst case: O(n) [values increase exponentially] */

public class InterpolationSearchAlgortihmApp
{
    public static void Main(string[] args)
    {

        //Creating integer array
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Best case

        int[] array2 = {4,7,19,647,942,747,369,789,572 }; //not best case, takes time

        //Calling InterpolationSearch method for searching 8
        int index = InterpolationSearch(array, 8);

        //If the index is -1, the value was not found
        Console.WriteLine(index == -1 ? "Value not found" : "Value found at index: " + index);
    }

    private static int InterpolationSearch(int[] array, int value)
    {
        int upperBound = array.Length - 1;
        int lowerBound = 0;
        //Default
        int probe = -1;

        //Looking while the value is between the upper and lower bounds
        while (value >= array[lowerBound] && value <= array[upperBound] && lowerBound <= upperBound)
        {
            //Formula to find the likely index of our value
            probe = (upperBound - lowerBound) * (value - array[lowerBound]) / (array[upperBound] - array[lowerBound]);

            Console.WriteLine("Lower Bound: " + lowerBound + " Upper Bound: " + upperBound + " Probe: " + probe);

            //If the probe is correct, return the index
            if (array[probe] == value)
            {
                return probe;
            }
            //If the probe is less than the value, increase the lower bound to make the search area smaller
            else if (array[probe] < value)
            {
                lowerBound = probe + 1;
            }
            //If the probe is greater than the value, decrease the upper bound to make the search area smaller
            else if(array[probe] > value)
            {
                upperBound = probe - 1;
            }
            //If the value is not found, return -1
            else
            {
                probe = -1;
            }
        }
        return probe;
    }
}