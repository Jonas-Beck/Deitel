namespace Ex_1807
{
    internal class Program_1807
    {
        static void Main(string[] args)
        {
            var generator = new Random();
            var data = new int[10];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(0, 10000);
            }

            Console.WriteLine("Unsorted Array:");
            Console.WriteLine(string.Join(" ", data));

            BucketSort sort = new BucketSort(data);
            sort.Sort();

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", sort.OriginalArray));
        }
    }
}