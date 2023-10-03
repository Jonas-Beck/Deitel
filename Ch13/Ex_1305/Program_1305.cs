namespace Ex_1305
{
    internal class Program_1305
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Type int number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number);
                    continueLoop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Log error");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please type a valid int number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("That is not a int number");
                }
            } while (continueLoop);

            /*
            do
            {
                try
                {
                    Console.Write("Type int number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number);
                    continueLoop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please type a valid int number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("That is not a int number");
                }
                catch (Exception)
                {
                    Console.WriteLine("Log error");
                }
            } while (continueLoop);
             
             */
        }
    }
}