using ClassLibrary_OOP;


namespace DZ_OOP
{
    internal class MyTreeTest
    {
        static void Main()
        {
            TestAdd();
            TestContains();
            TestClear();
            TestToArray();
        }

        static void TestAdd()
        {
            MyTree myTree = new MyTree();
            myTree.Add(10);
            myTree.Add(5);
            myTree.Add(15);
            myTree.Add(7);
            myTree.Add(12);

            Console.WriteLine("Test Add:");
            PrintArray(myTree.ToArray());

            Console.WriteLine();
        }

        static void TestContains()
        {
            MyTree myTree = new MyTree();
            myTree.Add(10);
            myTree.Add(5);
            myTree.Add(15);

            Console.WriteLine("Test Contains:");

            if (myTree.Contains(5))
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            Console.WriteLine();
        }

        static void TestClear()
        {
            MyTree myTree = new MyTree();
            myTree.Add(10);
            myTree.Add(5);
            myTree.Add(15);

            Console.WriteLine("Test Clear:");

            myTree.Clear();

            if (myTree.Count == 0)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            Console.WriteLine();
        }

        static void TestToArray()
        {
            MyTree myTree = new MyTree();
            myTree.Add(10);
            myTree.Add(5);
            myTree.Add(15);

            Console.WriteLine("Test ToArray:");

            var array = myTree.ToArray();

            Console.WriteLine("Array contents:");
            PrintArray(array);

            if (array.Length == 3 && array[0] == 5 && array[1] == 10 && array[2] == 15)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
