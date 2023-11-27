using ClassLibrary_OOP;


namespace DZ_OOP
{
    internal class MyListTest
    {
        static void Main()
        {
            AddTest();
            InsertTest();
            RemoveTest();
            ClearTest();
            ContainsTest();
            IndexOfTest();
            ToArrayTest();
            ReverseTest();
            CountTest();
        }

        static void AddTest()
        {
            MyList myList = new MyList();
            myList.Add(10);
            myList.Add(8);
            myList.Add(3);

            Console.WriteLine("AddTest:");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"{myList[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void InsertTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(15);
            myList.Insert(1, 10);

            Console.WriteLine("InsertTest:");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"{myList[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void RemoveTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Remove(10);

            Console.WriteLine("RemoveTest:");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"{myList[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void ClearTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Clear();

            Console.WriteLine("ClearTest:");

            if (myList.Count == 0)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            Console.WriteLine();
        }

        static void ContainsTest()
        {
            MyList myList = new MyList();

            myList.Add(5);
            myList.Add(10);
            myList.Add(15);

            Console.WriteLine("ContainsTest:");

            if (myList.Contains(10))
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            Console.WriteLine();
        }

        static void IndexOfTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);

            Console.WriteLine("IndexOfTest:");

            if (myList.IndexOf(10) == 1)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            Console.WriteLine();
        }

        static void ToArrayTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);

            var array = myList.ToArray();

            Console.WriteLine("ToArrayTest:");

            if (array.Length == 3)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            Console.WriteLine();
        }

        static void ReverseTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);

            myList.Reverse();

            Console.WriteLine("ReverseTest:");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"{myList[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void CountTest()
        {
            MyList myList = new MyList();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);

            Console.WriteLine("CountTest:");

            Console.WriteLine($"{myList.Count}");
        }
    }
}
