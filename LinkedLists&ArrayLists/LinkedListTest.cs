using System.Diagnostics;

namespace LinkedLists_ArrayLists
{
    public class LinkedListTest
    {
        public LinkedList<int> linkedList = new LinkedList<int>();

        public Stopwatch linkedListStopWatch = new Stopwatch();

        long elapsedTicks;
        long elapsedNanoseconds;

        public long GetFirstElementLinkedList()
        {
            //Reseting stopwatch before starting
            linkedListStopWatch.Reset();

            //Start the stopwatch before operation
            linkedListStopWatch.Start();

            //Getting first element of linked list
            var firstElement = linkedList.First();

            //Stopping the stopwatch after operation
            linkedListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = linkedListStopWatch.ElapsedTicks;

            //Converting ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }

        public long SearchElementLinkedList(int element)
        {
            //Reseting stopwatch before starting
            linkedListStopWatch.Reset();

            //Start the stopwatch before operation
            linkedListStopWatch.Start();

            //Check if element exists in linked list
            bool found = linkedList.Contains(element);

            //Stopping the stopwatch after operation
            linkedListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = linkedListStopWatch.ElapsedTicks; 

            // Convert ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }

        public long GetLastElementLinkedList()
        {
            //Reseting stopwatch before starting
            linkedListStopWatch.Reset();

            //Start the stopwatch before operation
            linkedListStopWatch.Start();

            //Getting last element of linked list
            var lastElement = linkedList.Last;

            //Stopping the stopwatch after operation
            linkedListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = linkedListStopWatch.ElapsedTicks;

            // Convert ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }

        public long RemoveElementLinkedList(int element)
        {
            //Reseting stopwatch before starting
            linkedListStopWatch.Reset();

            //Start the stopwatch before operation
            linkedListStopWatch.Start();

            //Removing element from linked list
            linkedList.Remove(element);

            //Stopping the stopwatch after operation
            linkedListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = linkedListStopWatch.ElapsedTicks;

            // Convert ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }
    }
}