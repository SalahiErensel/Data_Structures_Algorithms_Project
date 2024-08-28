using LinkedLists_ArrayLists;

public class LinkedListsVersusArrayListsApp
{
    public static void Main(string[] args)
    {
        ArrayListTest arrayListTest = new ArrayListTest();

        LinkedListTest linkedListTest = new LinkedListTest();

        //adding 1 million elements to linked list and array list
        for (int i = 0; i < 1000000; i++)
        {
            arrayListTest.arrayList.Add(i);
            linkedListTest.linkedList.AddLast(i);
        }

        // Getting the first element from array list
        Console.WriteLine($"Getting First Element of Array List in Nano Seconds: {arrayListTest.GetFirstElementArrayList()} ns");

        // Getting the first element from linked list
        Console.WriteLine($"\nGetting First Element of Linked List in Nano Seconds: {linkedListTest.GetFirstElementLinkedList()} ns");

        // Searching for an element in array list
        Console.WriteLine($"\nSearching Element in Array List in Nano Seconds: {arrayListTest.SearchElementArrayList(500505)} ns");

        // Searching for an element in linked list
        Console.WriteLine($"\nSearching Element in Linked List in Nano Seconds: {linkedListTest.SearchElementLinkedList(500505)} ns");

        //Getting last element in array list
        Console.WriteLine($"\nGetting Last Element of Array List in Nano Seconds: {arrayListTest.GetLastElementArrayList()} ns");

        //Getting last element from linked list
        Console.WriteLine($"\nGetting Last Element of Linked List in Nano Seconds: {linkedListTest.GetLastElementLinkedList()} ns");

        //Removing an element from array list
        Console.WriteLine($"\nRemoving Element from Array List in Nano Seconds: {arrayListTest.RemoveElementArrayList(679745)} ns");

        //Removing an element from linked list
        Console.WriteLine($"\nRemoving Element from Linked List in Nano Seconds: {linkedListTest.RemoveElementLinkedList(679745)} ns");

        //In linked lists, elements are stored in nodes and each node has a reference to the next node.(Doubly Linked Lists)
        //In array lists, elements are stored in contiguous memory locations and elements can be randomly accessed.
    }
}