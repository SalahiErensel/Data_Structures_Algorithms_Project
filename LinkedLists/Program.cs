public class LinkedListApp
{
    public static void Main(string[] args)
    {
        //Creating a doubly linked list which means next node and previous node addresses are known.
        LinkedList<string> linkedList = new LinkedList<string>();

        //Adding elements to the linked list
        linkedList.AddLast("Food");
        linkedList.AddLast("Sleep");
        linkedList.AddLast("Coding");
        linkedList.AddLast("Coding");
        linkedList.AddLast("Gaming");

        //First Element is Food, last element is Gaming
        Console.WriteLine("First of the linked list: " + linkedList.First.Value);
        Console.WriteLine("\nLast of the linked list: " + linkedList.Last.Value);
        Console.WriteLine("\nLinked list count: " + linkedList.Count);

        //Removing the first element from linked list
        linkedList.RemoveFirst();

        Console.WriteLine("\nFirst of the linked list after remove first: " + linkedList.First.Value);
        Console.WriteLine("\nLinked list count after remove first: " + linkedList.Count);

        //Removing the last element from linked list
        linkedList.RemoveLast();

        Console.WriteLine("\nLast of the linked list after remove last: " + linkedList.Last.Value);
        Console.WriteLine("\nLinked list count after remove last: " + linkedList.Count);

        //Removing the element "Sleep" from linked list
        linkedList.Remove("Sleep");

        Console.WriteLine("\nLinked list count after remove 'Sleep': " + linkedList.Count);

        //Adds after the first element
        linkedList.AddAfter(linkedList.First, "Sleep");

        //Adds before the last element
        linkedList.AddBefore(linkedList.Last, "Gaming");

        //Clearing the linked list
        linkedList.Clear();

        //Finds the first coding element
        linkedList.Find("Coding");

        //Finds the last coding element
        linkedList.FindLast("Coding");
    }
}