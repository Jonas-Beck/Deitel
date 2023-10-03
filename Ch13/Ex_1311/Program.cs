namespace Ex_1311
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Write int number:");
                int number = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException");
            }
        }
    }
}