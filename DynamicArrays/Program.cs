using DynamicArrays;
using System.Collections;

public class DynamicArraysApp
{
    public static void Main(string[] args)
    {
        //Creating a dynamic array
        ArrayList dynamicArray = new ArrayList();

        //Adding elements to the dynamic array
        dynamicArray.Add("Food");
        dynamicArray.Add("Sleep");
        dynamicArray.Add("Coding");
        dynamicArray.Add("Gaming");

        //First Element is Food, last element is Gaming
        Console.WriteLine("First of the dynamic array: " + dynamicArray[0]);
        Console.WriteLine("\nLast of the dynamic array: " + dynamicArray[dynamicArray.Count - 1]);
        Console.WriteLine("\nDynamic array count: " + dynamicArray.Count);

        //Removing the first element from dynamic array
        dynamicArray.RemoveAt(0);

        Console.WriteLine("\nFirst of the dynamic array after remove first: " + dynamicArray[0]);
        Console.WriteLine("\nDynamic array count after remove first: " + dynamicArray.Count);

        //Removing the last element from dynamic array
        dynamicArray.RemoveAt(dynamicArray.Count - 1);

        Console.WriteLine("\nLast of the dynamic array after remove last: " + dynamicArray[dynamicArray.Count - 1]);
        Console.WriteLine("\nDynamic array count after remove last: " + dynamicArray.Count);

        //Removing the element "Sleep" from dynamic array
        dynamicArray.Remove("Sleep");

        Console.WriteLine("\nDynamic array count after remove 'Sleep': " + dynamicArray.Count);

        //Inserts at the first index
        dynamicArray.Insert(0, "Sleep");

        //Inserts at the last index
        dynamicArray.Insert(dynamicArray.Count, "Gaming");

        Console.WriteLine("\nDynamic array last index  after adding 'Gaming': " + dynamicArray.Count);

        //Finds the index of first coding element
        Console.WriteLine("\nIndex of Coding element: " + dynamicArray.IndexOf("Coding"));

        //Finds the index of last coding element
        dynamicArray.LastIndexOf("Coding");

        //Clearing the dynamic array
        dynamicArray.Clear();



        //*******************************************************************************************************************************************************************//

        //Another way of creating dynamic arrays by your own class. use DynamicArray class

        //Creating a dynamic array with capacity 5
        DynamicArray dynamicArray2 = new DynamicArray(5);

        //Adding to array
        dynamicArray2.Add("A");
        dynamicArray2.Add("B");
        dynamicArray2.Add("C");
        dynamicArray2.Add("D");
        dynamicArray2.Add("E");
        dynamicArray2.Add("F");

        //Inserting at index 0 element x
        dynamicArray2.Insert(0, "X");

        //Deleting element 
        dynamicArray2.Delete("A");
        dynamicArray2.Delete("B");
        dynamicArray2.Delete("C");

        Console.WriteLine("\nSearching X in Array: " + dynamicArray2.Search("X"));

        Console.WriteLine("\nSearching A in Array after deleting: " + dynamicArray2.Search("A"));

        Console.WriteLine("\nSecond Dynamic Array Elements: " + dynamicArray2.toString());

        Console.WriteLine("\nSecond Dynamic Array Is Empty: " + dynamicArray2.isEmpty());
        Console.WriteLine("\nSecond Dynamic Array Size: " + dynamicArray2.size);
        Console.WriteLine("\nSecond Dynamic Array Capacity: " + dynamicArray2.capacity);
    }
}