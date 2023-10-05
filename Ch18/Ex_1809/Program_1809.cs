namespace Ex_1809
{
    internal class Program_1809
    {
        static void Main(string[] args)
        {
            var generator = new Random();
            var data = new int[10];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(10, 100);
            }

            Console.WriteLine(String.Join(" ", data));
            Console.Write("Write number to search for:");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result: {RecursiveBinarySearch(data, key, 0, data.Length - 1)}");

        }

        public static int RecursiveBinarySearch(int[] values, int searchKey, int startingIndex, int endingIndex)
        {
            int middle = (startingIndex + endingIndex + 1) / 2;

            if (values[middle] == searchKey)
            {
                return middle;
            }
            else if (values[middle] > searchKey)
            {
                return RecursiveBinarySearch(values, searchKey, startingIndex, middle - 1);
            }
            else if (values[middle] < searchKey)
            {
                return RecursiveBinarySearch(values, searchKey, middle + 1, endingIndex);
            }
            else
            {
                return -1;
            }

        }

        /* Fig 18.3
        public static int BinarySearch(int[] values, int searchElement)
        {
            var low = 0;
            var high = values.Length - 1;
            var middle = (low + high +1) / 2;

            do
            {
                if (searchElement == values[middle])
                {
                    return middle;
                }
                else if(searchElement < values[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
                middle = (low + high + 1) / 2;

            } while (low <= high);

            return -1;
        }
        */
    }
}