namespace Ex_0736
{
    internal class Program_0736
    {
        static void Main(string[] args)
        {
            Tower(2, 1, 3, 2);
        }

        static void Tower(int NumberOfDisks, int StartingPeg, int TargetPeg, int TemporaryPeg)
        {
            if (NumberOfDisks == 1)
            {
                Console.WriteLine($"{StartingPeg} > {TargetPeg}");
            }
            else
            {
                Tower(NumberOfDisks - 1, StartingPeg, TemporaryPeg, TargetPeg);
                Console.WriteLine($"{StartingPeg} > {TargetPeg}");
                Tower(NumberOfDisks - 1, TemporaryPeg, TargetPeg, StartingPeg);
            }
        }
    }
}