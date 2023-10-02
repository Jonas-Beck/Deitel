namespace Ex_1212
{
    internal class Program_1212
    {
        static void Main(string[] args)
        {
            // create a List<IPayable> and initialize it with four 
            // objects of classes that implement interface IPayable
            var payableObjects = new List<IPayable>() {
            new Invoice("01234", "seat", 2, 375.00M),
            new Invoice("56789", "tire", 4, 79.95M),
            new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M),
            new BasePlusCommissionEmployee("Jane", "Smith", "222-22-2222", 1000, 0.5M, 500),
            new CommissionEmployee("Jack", "Smith", "333-33-3333", 1000, 0.5M),
            new HourlyEmployee("Jonas", "Smith", "444-44-4444", 40, 37)};


            Console.WriteLine(
               "Invoices and Employees processed polymorphically:\n");

            // generically process each element in payableObjects
            foreach (var payable in payableObjects)
            {
                // output payable and its appropriate payment amount
                Console.WriteLine($"{payable}");
                if (payable is BasePlusCommissionEmployee)
                {
                    var employee = (BasePlusCommissionEmployee)payable;

                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine($"New base salary with 10% increase is: {employee.BaseSalary:C} ");

                }
                Console.WriteLine($"payment due: {payable.GetPaymentAmount():C}\n");
            }
        }
    }
}