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
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight in Pounds: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            HealthProfile profile = new HealthProfile(firstName, lastName, gender, month, day, year, height, weight);

            Console.WriteLine(profile.AgeInYears());


        }
    }
}