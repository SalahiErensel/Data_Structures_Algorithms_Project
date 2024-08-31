/*
 * Calls itself. Can be a substitute for iteration. Divide problem into sub-problems of same type as original. 
 * Commonly used with advanced sorting algorithms and navigating trees.
*/

public class RecursionApp
{
    public static void Main(string[] args)
    {
        walk(5);
        walkRecursive(5);
        Console.WriteLine("\nFactorial of 7 is: " + factorial(7));
        Console.WriteLine("\nPower of of 5 to the 4 is: " + power(5, 4));
    }

    //Normal method to count steps
    private static void walk(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine("\nWalking step " + i);
        }
    }

    //Recursive method to count steps
    private static void walkRecursive(int steps)
    {
        if (steps < 1)
        {
            return;
        }
        Console.WriteLine("\nRecursiveWalking step " + steps);
        walkRecursive(steps - 1);
    }

    //Recursive method to calculate factorial
    private static int factorial(int num)
    {
        //base case
        if(num < 1)
        {
            return 1;
        }
        return num * factorial(num - 1); //recursive case
    }

    //Recursive method to calculate power
    private static int power(int baseNum, int exponent)
    {
        //base case
        if (exponent == 0)
        {
            return 1;
        }

        return baseNum * power(baseNum, exponent - 1); //recursive case
    }
}