namespace Ex_0415
{
    internal class HealthProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int MonthOfBirth { get; set; }
        public int DayOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        // Height in inches
        public int Height { get; set; }
        // Weight in Pounds
        public int Weight { get; set; }

        public HealthProfile(string firstName, string lastName, string gender, int monthOfBirth, int dayOfBirth, int yearOfBirth, int height, int weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            MonthOfBirth = monthOfBirth;
            DayOfBirth = dayOfBirth;
            YearOfBirth = yearOfBirth;
            Height = height;
            Weight = weight;
        }

        public int AgeInYears()
        {
            DateTime BirthDate = new DateTime(YearOfBirth, MonthOfBirth, DayOfBirth);
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.Year < BirthDate.DayOfYear)
                age = age - 1;

            return age;
        }
        public int MaxHeartRate()
        {
            return 1;
        }
        public int TargetHeartRate()
        {
            return 1;
        }
        public double BMI()
        {
            return 1;

        }

    }
}
