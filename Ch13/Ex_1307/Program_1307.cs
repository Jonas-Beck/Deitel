namespace Ex_1307
{
    internal class Program_1307
    {
        static void Main(string[] args)
        {
            try
            {
                ThrowExample();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument Exception in main");
            }

        }

        public static void ThrowExample()
        {
            try
            {
                Console.WriteLine("Throw Exception from ThrowExample() Try block");
                throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Rethrow exception from ThrowExample() Catch Block");
                throw;
            }
        }
    }
}