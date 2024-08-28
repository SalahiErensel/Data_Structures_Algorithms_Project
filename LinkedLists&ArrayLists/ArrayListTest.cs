using System.Collections;
using System.Diagnostics;

namespace LinkedLists_ArrayLists
{
    public class ArrayListTest
    {
        public ArrayList arrayList = new ArrayList();
        public Stopwatch arrayListStopWatch = new Stopwatch();

        long elapsedTicks;
        long elapsedNanoseconds;

        public long GetFirstElementArrayList()
        {
            //Reseting stopwatch before starting
            arrayListStopWatch.Reset();

            //Start the stopwatch before operation
            arrayListStopWatch.Start();

            //Getting first element of array list
            var firstElement = arrayList[0];

            //Stopping the stopwatch after operation
            arrayListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = arrayListStopWatch.ElapsedTicks;

            //Converting ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }

        public long SearchElementArrayList(object element)
        {
            //Reseting stopwatch before starting
            arrayListStopWatch.Reset();

            //Start the stopwatch before operation
            arrayListStopWatch.Start();

            //Check if element exists in array list
            bool found = arrayList.Contains(element);

            //Stopping the stopwatch after operation
            arrayListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = arrayListStopWatch.ElapsedTicks;

            // Convert ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }

        public long GetLastElementArrayList()
        {
            //Reseting stopwatch before starting
            arrayListStopWatch.Reset();

            //Start the stopwatch before operation
            arrayListStopWatch.Start();

            //Getting last element of array list
            var lastElement = arrayList[arrayList.Count - 1];

            //Stopping the stopwatch after operation
            arrayListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = arrayListStopWatch.ElapsedTicks;

            // Convert ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }

        public long RemoveElementArrayList(object element)
        {
            //Reseting stopwatch before starting
            arrayListStopWatch.Reset();

            //Start the stopwatch before operation
            arrayListStopWatch.Start();

            //Removing element from array list
            arrayList.Remove(element);

            //Stopping the stopwatch after operation
            arrayListStopWatch.Stop();

            //Getting the elapsed ticks
            elapsedTicks = arrayListStopWatch.ElapsedTicks;

            // Convert ticks to nanoseconds
            elapsedNanoseconds = (elapsedTicks * 1_000_000_000) / Stopwatch.Frequency;

            return elapsedNanoseconds;
        }
    }
}
