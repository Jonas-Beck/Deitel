namespace Ex_1806
{
    internal class Program_1806
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] data = new int[10];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(10, 100);
            }

            Console.WriteLine("Unsorted Array:");
            Console.WriteLine(string.Join(" ", data));

            BubbleSort(data);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", data));

            int[] sortedData = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", sortedData));

            BubbleSort(sortedData);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", sortedData));

        }

        public static void BubbleSort(int[] values)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                int swaps = 0;

                for (int index = 0; index < i; index++)
                {
                    // Check if index postion higher then next value
                    if (values[index] > values[index + 1])
                    {
                        // Swap values 
                        int temp = values[index];
                        values[index] = values[index + 1];
                        values[index + 1] = temp;
                        // Increment swaps counter
                        swaps++;
                    }
                }

                // If no swaps were made stop loop
                if (swaps == 0)
                {
                    break;
                }
            }
        }

    }
}