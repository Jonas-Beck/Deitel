namespace Ex_1807
{
    internal class BucketSort
    {
        public int[] OriginalArray { get; set; }
        public int MaxDigits { get; set; }
        public List<List<int>> Bucket { get; set; }


        public BucketSort(int[] array)
        {
            OriginalArray = array;
            MaxDigits = GetMaxDigits(array);


            Bucket = new List<List<int>>();

            // Add 9 rows
            for (int i = 0; i < 10; i++)
            {
                Bucket.Add(new List<int> { });
            }

        }

        public void Sort()
        {
            // Loop based on the amount of digits 
            for (int i = 0; i < MaxDigits; i++)
            {
                DistributionPass(i);
                GatheringPass();
            }
        }

        public void DistributionPass(int index)
        {
            // Loop all numbers in array
            foreach (int number in OriginalArray)
            {
                ///Calculte the divisor based on index
                int divisor = (int)Math.Pow(10, index);

                //Extract the digit at the specified index
                int digit = (number / divisor) % 10;

                // Add number to array row based on digit
                Bucket[digit].Add(number);
            }
        }

        public void GatheringPass()
        {
            //Clear Original Array
            Array.Clear(OriginalArray);

            //Counter
            int counter = 0;

            // Loop all numbers in Bucket array and add to Original Array in that order
            foreach (var list in Bucket)
            {
                foreach (var number in list)
                {
                    OriginalArray[counter++] = number;
                }
            }

            //Clear Bucket Array
            foreach (var list in Bucket)
            {
                list.Clear();
            }
        }

        private int GetMaxDigits(int[] array)
        {
            //MaxDigit Counter
            int maxDigits = 0;

            // Loop all numbers in array
            foreach (var number in array)
            {
                // Check amount of digits 
                int digits = number.ToString().Length;
                if (digits > maxDigits)
                {
                    maxDigits = digits;
                }
            }

            return maxDigits;
        }
    }
}
