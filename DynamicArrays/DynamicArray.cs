namespace DynamicArrays
{
    public class DynamicArray
    {
        public int size;
        //Default
        public int capacity = 10;

        Object[] array;

        //Creating default 10 capacity array
        public DynamicArray()
        {
            this.array = new Object[capacity];
        }

        //Creating array with given capacity
        public DynamicArray(int capacity)
        {
            this.capacity = capacity;
            this.array = new Object[capacity];
        }

        //Adding element to the array
        public void Add(Object data)
        {
            if(size >= capacity)
            {
                Grow();
            }
            array[size] = data;
            size++;
        }

        //Inserting element to the array with index and element data
        public void Insert(int index, Object data)
        {
            if(size >= capacity)
            {
                Grow();
            }

            //Moving element to right to insertion
            for(int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = data;
            size++;
        }

        //Deleting element from the array
        public void Delete(Object data)
        {
            //Moving element to left to deletion
            for (int i = 0; i < size; i++)
            {
                if (array[i] == data)
                {
                    for (int j = 0; j < (size - i - 1); j++)
                    {
                        array[i + j] = array[i + j + 1];
                    }

                    array[size -1] = null;
                    size--;
                    if(size <= (int) (capacity / 3)){
                        Shrink();
                    }
                    
                    break;
                }
            }
        }

        //Searching element in the array
        public int Search(Object data)
        {
            for(int i = 0; i < size; i++)
            {
                if (array[i] == data)
                {
                    return i;
                }
            }

            //if value is not in the array
            return -1;
        }

        //Making array bigger
        private void Grow()
        {
            int newCapacity = (int) capacity * 2;
            Object[] newArray = new Object[newCapacity];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            capacity = newCapacity;
            array = newArray;
        }

        //Making array smaller for excess memory usage and efficiency
        private void Shrink()
        {
            int newCapacity = (int)capacity / 2;
            Object[] newArray = new Object[newCapacity];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            capacity = newCapacity;
            array = newArray;
        }

        //checking if array is empty
        public bool isEmpty()
        {
            return size == 0;
        }

        //Returning elements in the array
        public String toString()
        {
            String str = "";

            for(int i = 0; i < size; i++)
            {
                str += array[i] + ", ";
            }

            if(str != "")
            {
                str = "[" + str.Substring(0, str.Length - 2) + "]";
            }

            else
            {
                str = "[]";
            }

            return str;
        }
    }
}