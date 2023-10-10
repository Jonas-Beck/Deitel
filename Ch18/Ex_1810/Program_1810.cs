namespace Ex_1810
{
    internal class Program_1810
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

            QuickSort(data);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", data));

        }

        static void QuickSort(int[] values)
        {
            QuickSortHelper(values, 0, values.Length - 1);
        }
        static void QuickSortHelper(int[] values, int startingIndex, int endingIndex)
        {
            if (startingIndex >= endingIndex)
            {
                return;
            }

            int pivot = startingIndex;
            int left = startingIndex;
            int right = endingIndex;

            while (left != right)
            {
                for (int i = right; i >= left; i--)
                {
                    if (pivot == i)
                    {
                        break;
                    }
                    if (values[pivot] > values[i])
                    {
                        // Swap values 
                        int temp = values[i];
                        values[i] = values[pivot];
                        values[pivot] = temp;

                        pivot = i;
                        left++;
                        break;
                    }
                    right--;
                }
                for (int i = left; i <= right; i++)
                {
                    if (pivot == i)
                    {
                        break;
                    }
                    if (values[pivot] < values[i])
                    {
                        // Swap values 
                        int temp = values[i];
                        values[i] = values[pivot];
                        values[pivot] = temp;

                        pivot = i;
                        right--;
                        break;
                    }
                    left++;
                }
            }

            QuickSortHelper(values, startingIndex, pivot - 1);
            QuickSortHelper(values, pivot + 1, endingIndex);
        }
    }
}