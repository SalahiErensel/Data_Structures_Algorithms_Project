using System.Collections;

public class PriorityQueuesApp
{
    public static void Main(string[] args)
    {
        //Adding to priority queue
        PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

        priorityQueue.Enqueue("Food", 3);
        priorityQueue.Enqueue("Sleep", 2);
        priorityQueue.Enqueue("Coding", 4);
        priorityQueue.Enqueue("Gaming", 1);

        //First Element is Coding with highest priority, last element is Gaming with lowest priority

        Console.WriteLine("Last of the priority queue: " + priorityQueue.Peek());
        Console.WriteLine("\nPriority queue count: " + priorityQueue.Count);

        //Removing the least priority element from priority queue
        string dequeuedElement = priorityQueue.Dequeue();

        Console.WriteLine("\nElement dequeued: " + dequeuedElement);
        Console.WriteLine("\nPriority queue count after dequeue: " + priorityQueue.Count);
        Console.WriteLine("\nLast of the priority queue after dequeue: " + priorityQueue.Peek());

        priorityQueue.Clear();
    }
}