using Interfaces_OOP;

namespace ClassLibrary_OOP
{
    public class MyList : IList
    {
        private object[] array;
        private int count;
        private int capacity;

        public MyList()
        {
            capacity = 10;
            array = new object[capacity];
            count = 0;
        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            array = new object[capacity];
            count = 0;
        }

        private void ResizeArray()
        {
            capacity *= 2;
            object[] newArray = new object[capacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public void Add(object item)
        {
            if (count == capacity)
            {
                ResizeArray();
            }
            array[count++] = item;
        }

        public void Insert(int index, object item)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();

            if (count == capacity)
            {
                ResizeArray();
            }

            for (int i = count; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
            count++;
        }

        public void Remove(object item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[count - 1] = null;
            count--;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                array[i] = null;
            }
            count = 0;
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                    return true;
            }
            return false;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public object[] ToArray()
        {
            object[] newArray = new object[count];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public void Reverse()
        {
            int i = 0;
            int j = count - 1;
            while (i < j)
            {
                object temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                array[index] = value;
            }
        }

        public int Count
        {
            get { return count; }
        }
    }
}
