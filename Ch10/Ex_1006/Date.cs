namespace Ex_1006
{
    internal class Date
    {
        private int month; // 1-12
        private int day; // 1-31 based on month
        private int year;
        private int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // constructor: use property Month to confirm proper value for month; 
        // use property Day to confirm proper value for day
        public Date(int month, int day, int year)
        {
            Month = month; // validates month
            Year = year; // could validate year
            Day = day; // validates day
            Console.WriteLine($"Date object constructor for date {this}");
        }

        // property that gets and sets the month
        public int Month
        {
            get
            {
                return month;
            }
            private set // make writing inaccessible outside the class
            {
                if (value <= 0 || value > 12) // validate month
                {
                    throw new ArgumentOutOfRangeException(
                       nameof(value), value, $"{nameof(Month)} must be 1-12");
                }

                month = value;
            }
        }

        // property that gets and sets the day
        public int Day
        {
            get
            {
                return day;
            }
            private set // make writing inaccessible outside the class
            {
                // check if day in range for month
                if (value > 0 && value <= daysPerMonth[Month])
                {
                    day = value;
                }
                else if (Month == 2 && value == 29 && (DateTime.IsLeapYear(Year)))
                {
                    day = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            private set
            {
                // Check for negative value
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Year)} Cannot be <= 0");
                }
                year = value;
            }
        }

        public void NextDay()
        {
            try
            {
                Day = ++Day;
            }
            catch (ArgumentOutOfRangeException)
            {
                if (Month == 12)
                {
                    Month = 1;
                    Year++;
                }
                else
                {
                    Month++;
                }
                Day = 1;
            }
        }
        // return a string of the form month/day/year
        public override string ToString() => $"{Month}/{Day}/{Year}";
    }
}
