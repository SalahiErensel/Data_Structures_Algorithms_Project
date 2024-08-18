//Last In First Out Structure
//Push to add to top, pop to remove from top
public class StackAlgorithmApp
{
    public static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        //Adding to stack
        stack.Push("GTA V");
        stack.Push("FIFA 24");
        stack.Push("PES 24");
        stack.Push("NFS");

        //First Element is NFS, last element is GTA V

        Console.WriteLine("Top of the stack: " + stack.Peek());
        Console.WriteLine("\nStack count: " + stack.Count);
        Console.WriteLine("\nStack contains 'PES 24': " + stack.Contains("PES 24"));
        Console.WriteLine("\nStack contains 'PES 25': " + stack.Contains("PES 25"));

        //Removing from stack
        string poppedGame = stack.Pop();

        Console.WriteLine("\nGame popped: " + poppedGame);
        Console.WriteLine("\nStack count after pop: " + stack.Count);
        Console.WriteLine("\nTop of the stack after pop: " + stack.Peek());

        stack.Clear();
    }
}