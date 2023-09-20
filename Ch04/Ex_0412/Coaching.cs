namespace Ex_0412
{
    internal class Coaching
    {
        public string CoachingType { get; set; }
        public int NumberOfPlayers { get; set; }
        public string ClassTimings { get; set; }
        public decimal Charges { get; set; }

        public Coaching(string coachingType, int numberOfPlayers, string classTiming, decimal charges)
        {
            CoachingType = coachingType;
            NumberOfPlayers = numberOfPlayers;
            ClassTimings = classTiming;
            Charges = charges;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Coaching type: {CoachingType}");
            Console.WriteLine($"Number of players: {NumberOfPlayers}");
            Console.WriteLine($"Class Timings: {ClassTimings}");
            Console.WriteLine($"Charge for Coaching {Charges:C}");
            Console.WriteLine();
        }
    }
}
