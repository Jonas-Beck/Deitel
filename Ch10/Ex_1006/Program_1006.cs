namespace Ex_1006
{
    internal class Program_1006
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(2, 1, 2023);
            Console.WriteLine(date1.ToString());
            for (int i = 0; i < 50; i++)
            {
                date1.NextDay();
                Console.WriteLine(date1.ToString());
            }
        }
    }
}