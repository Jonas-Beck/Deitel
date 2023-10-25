namespace Ex_2119
{
    internal class Program_2119
    {
        static void Main(string[] args)
        {
            var random = new Random();

            IEnumerable<IGrouping<int, int>> values1 = Enumerable.Range(1, 60000000)
                                                                 .Select(x => random.Next(1, 7))
                                                                 .GroupBy(value => value)
                                                                 .OrderBy(value => value.Key);

            Console.WriteLine($"{"Face"}{"Frequency",10}");
            foreach (var value in values1)
            {
                Console.WriteLine($"{value.Key,4}{value.Count(),10}");

            }

        }
    }
}