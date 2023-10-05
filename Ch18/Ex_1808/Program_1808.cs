namespace Ex_1808
{
    internal class Program_1808
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
            Console.WriteLine($"Result: {RecursiveLinearSearch(data, key, 0)}");

        }

        public static int RecursiveLinearSearch(int[] values, int searchKey, int startingIndex)
        {
            if (startingIndex == values.Length)
            {
                return -1;
            }
            return values[startingIndex] == searchKey ? startingIndex : RecursiveLinearSearch(values, searchKey, startingIndex + 1);
        }

        /* Fig 18.2
        public static int LinearSearch(int[] values, int searchKey)
        {
            for (int index = 0; index < values.Length; ++index)
            {
                if (values[index] == searchKey)
                {
                    return index;
                }
            }
            return -1;
        }
        */
    }
}