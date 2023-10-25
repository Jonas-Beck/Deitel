namespace Ex_2117
{
    internal class Program_2117
    {
        static void Main(string[] args)
        {
            // create derived-class objects
            var salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
            var hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            // create List<Employee> and initialize with employee objects
            var employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };

            var employeesLINQ = employees.Select(employee =>
            {
                // Check if employee is a BasePlusCommissionEmployee
                if (employee is BasePlusCommissionEmployee basePlusEmployee)
                {
                    // Update BaseSalary
                    basePlusEmployee.BaseSalary *= 1.10M;

                    // Return Anonymous object with FirstName and Updated Earning
                    return new { employee.FirstName, Earning = basePlusEmployee.Earnings() };
                }

                // Return Anonymous with FirstName and Earning
                return new { employee.FirstName, Earning = employee.Earnings() };
            }).ToList();

            // Print all objects in EmployeesLINQ
            foreach (var employee in employeesLINQ)
            {
                Console.WriteLine($"{employee.FirstName} {employee.Earning:C}");
            }

        }
    }
}