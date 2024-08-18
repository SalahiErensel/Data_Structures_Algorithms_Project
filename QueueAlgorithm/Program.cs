//First In First Out Structure
//First element removed, second becomes first, last coming element becomes last.

public class QueueAlgorithmApp
{
    public static void Main(string[] args)
    {
        //Adding to queue
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("GTA V");
        queue.Enqueue("FIFA 24");
        queue.Enqueue("PES 24");
        queue.Enqueue("NFS");

        //First Element is GTA V, last element is NFS

        Console.WriteLine("Top of the queue: " + queue.Peek());
        Console.WriteLine("\nQueue count: " + queue.Count);
        Console.WriteLine("\nQueue contains 'PES 24': " + queue.Contains("PES 24"));
        Console.WriteLine("\nQueue contains 'PES 25': " + queue.Contains("PES 25"));

        //Removing from queue
        string dequeuedGame = queue.Dequeue();

        Console.WriteLine("\nGame dequeued: " + dequeuedGame);
        Console.WriteLine("\nQueue count after dequeue: " + queue.Count);
        Console.WriteLine("\nTop of the queue after dequeue: " + queue.Peek());

        queue.Clear();
    }
}