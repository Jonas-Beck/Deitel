namespace Ex_2007
{
    internal class Program_2007
    {
        static void Main(string[] args)
        {
            int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10 };

            PrintArray(intElements, "intElements");

            Console.Write("Insert number to search for:");
            int intSearch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Search(intElements, {intSearch}): {Search(intElements, intSearch)}\n");

            PrintArray(doubleElements, "doubleElements");

            Console.Write("Insert number to search for:");
            double doubleSearch = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Search(doubleElements, {doubleSearch}): {Search(doubleElements, doubleSearch)}\n");

        }

        static int Search<T>(T[] array, T key) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(key) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        static void PrintArray<T>(T[] array, string name) where T : IComparable
        {
            Console.WriteLine(name);
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}