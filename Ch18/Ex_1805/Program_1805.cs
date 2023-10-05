namespace Ex_1805
{
    internal class Program_1805
    {
        static void Main(string[] args)
        {
            var generator = new Random();
            var data = new int[10];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(10, 100);
            }

            Console.WriteLine("Unsorted Array:");
            Console.WriteLine(string.Join(" ", data));

            BubbleSort(data);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", data));


        }

        public static void BubbleSort(int[] values)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                for (int index = 0; index < i; index++)
                {
                    // Check if index postion higher then next value
                    if (values[index] > values[index + 1])
                    {
                        // Swap values 
                        int temp = values[index];
                        values[index] = values[index + 1];
                        values[index + 1] = temp;
                    }
                }
            }
        }
    }
}