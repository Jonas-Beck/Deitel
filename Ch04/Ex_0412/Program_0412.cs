namespace Ex_0412
{
    internal class Program_0412
    {
        static void Main(string[] args)
        {
            Coaching Coach = new Coaching("Soccer", 10, "Class Timing", 500);

            Coach.DisplayDetails();

            Coach.NumberOfPlayers = 5;
            Coach.Charges = 250;

            Coach.DisplayDetails();
        }
    }
}