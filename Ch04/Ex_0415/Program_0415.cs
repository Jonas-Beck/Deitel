namespace Ex_0415
{
    internal class Program_0415
    {
        static void Main(string[] args)
        {
            Console.Write("What is your firstname: ");
            string firstName = Console.ReadLine();
            Console.Write("What is your lastname: ");
            string lastName = Console.ReadLine();
            Console.Write("What is your gender: ");
            string gender = Console.ReadLine();

            Console.Write("What month are you born(Number format): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("What day are you born(Number format): ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("What year are you born: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight in Pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            HealthProfile profile = new HealthProfile(firstName, lastName, gender, month, day, year, height, weight);
            Console.WriteLine($"Firstname: {profile.FirstName}");
            Console.WriteLine($"Lastname: {profile.LastName}");
            Console.WriteLine($"Gender: {profile.Gender}");
            Console.WriteLine($"Birthdate: {profile.DayOfBirth}-{profile.MonthOfBirth}-{profile.YearOfBirth}");
            Console.WriteLine($"Height: {profile.Height}");
            Console.WriteLine($"Weight: {profile.Weight}");

            Console.WriteLine($"Age in Years: {profile.AgeInYears()}");
            Console.WriteLine($"BMI: {profile.BMI()}");
            Console.WriteLine($"Maximum heart rate: {profile.MaxHeartRate()}");
            Console.WriteLine($"Target heart rate: {profile.TargetHeartRate()}");



        }
    }
}