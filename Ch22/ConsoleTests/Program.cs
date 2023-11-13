using Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTests
{
    internal class Program
    {


        static void Main(string[] args)
        {

            string[] countriesInEu = { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Slovenia", "Spain", "Sweden" };

            string[] countriesInAmericas = { "Canada", "USA", "Mexico", "Guatemala", "Belize", "El Salvador", "Honduras", "Costa Rica", "Nicaragua", "Panama", "Colombia", "Venezuela", "Guyana", "Suriname", "Brazil", "Ecuador", "Peru", "Bolivia", "Chile", "Argentina", "Paraguay", "Uruguay" };


            NorthwindContext context = new();
            // 8.1

            // Select
            var select1 = context.Products.Where(product => product.Discontinued == true);

            var select2 = context.Suppliers.Where(supplier => supplier.Region == "Québec");

            var select3 = context.Suppliers.Where(supplier => supplier.Country == "Germany" || supplier.Country == "France");

            var select4 = context.Suppliers.Where(supplier => supplier.HomePage == null);

            var select5 = context.Suppliers.Where(supplier => countriesInEu.Contains(supplier.Country) && supplier.HomePage != null);

            var select6 = context.Employees.Where(employee => employee.FirstName.StartsWith("M"));

            var select7 = context.Employees.Where(employee => employee.LastName.EndsWith("an"));

            var select8 = context.Employees.Where(employee => employee.TitleOfCourtesy == "Ms." || employee.TitleOfCourtesy == "Mrs.");

            var select9 = context.Employees.Where(employee => employee.Title == "Sales Representative" && employee.Country == "UK");

            var select10 = context.Products.Count();

            var select11 = context.Products.Select(product => product.UnitPrice)
                                           .Average();

            var select12 = context.Products.Select(product => product.UnitPrice)
                                           .Where(price => price > 20)
                                           .OrderByDescending(price => price);

            var select13 = context.Products.Where(product => product.UnitsInStock == 0)
                                           .OrderBy(product => product.ProductName);

            var select14 = context.Products.Where(product => product.UnitsInStock == 0 && product.UnitsOnOrder == 0 && product.Discontinued == false)
                                           .OrderByDescending(product => product.ProductName);

            var select15 = context.Customers.Where(customer => (customer.Country == "France" && customer.ContactTitle == "Owner") ||
                                                               (customer.Country == "UK" && customer.ContactTitle == "Sales Representative"))
                                            .OrderBy(customer => customer.Country)
                                            .ThenBy(customer => customer.CompanyName);

            var select16 = context.Customers.Where(customer => countriesInAmericas.Contains(customer.Country) && customer.Fax == "no fax number")
                                            .OrderBy(customer => customer.CompanyName);

            // UPDATE

            var update1_suppliers = context.Suppliers.Where(supplier => supplier.Fax == null);
            var update1_customers = context.Customers.Where(customer => customer.Fax == null);

            foreach (var supplier in update1_suppliers)
            {
                supplier.Fax = "no fax number";
            }
            foreach (var customer in update1_customers)
            {
                customer.Fax = "no fax number";
            }

            var update2 = context.Products.Where(product => product.Discontinued == false && product.ReorderLevel == 0 && product.UnitsInStock < 20);

            foreach (var product in update2)
            {
                product.ReorderLevel = 10;
            }

            var update3 = context.Customers.Where(customer => customer.Country == "Spain");

            foreach (var customer in update3)
            {
                switch (customer.City)
                {
                    case "Madrid":
                        customer.Region = "Madrid";
                        break;
                    case "Barcelona":
                        customer.Region = "Catalonien";
                        break;
                    case "Sevilla":
                        customer.Region = "Andalucia";
                        break;
                    default:
                        break;
                }
            }

            var update4 = context.Customers.Where(customer => customer.CompanyName == "Simons bistro")
                                           .FirstOrDefault();
            if (update4 != null)
            {
                update4.CompanyName = "Simons Vaffelhus";
                update4.Address = "Stranvejen 65";
                update4.PostalCode = "7100";
                update4.City = "Vejle";
            }


            var update5 = context.Customers.Where(customer => customer.CompanyName == "White Clover Markets")
                                           .FirstOrDefault();

            if (update5 != null)
            {
                update5.Address = "247 New Avennue";
                update5.City = "Chicago";
                update5.Phone = "555-20159";
            }

            var update6 = context.Employees.Where(employee => employee.EmployeeId == 3)
                                           .FirstOrDefault();

            if (update6 != null)
            {
                update6.Address = "908 W. Capital Way";
                update6.City = "Tacoma";
                update6.PostalCode = "98401";
            }

            // INSERT

            var insert1 = new Employee()
            {
                LastName = "Larsen",
                FirstName = "Kim",
                TitleOfCourtesy = "Mr.",
                HireDate = new DateTime(2023, 1, 1),
                Address = "Violvej 45",
                City = "Sønderborg",
                PostalCode = "6400",
                Extension = "0745"
            };

            //context.Employees.Add(insert1);

            var insert2 = new Employee[]
            {
                new Employee()
                {
                    LastName = "Mikel Rasmusen",
                    FirstName = "Mads",
                    TitleOfCourtesy = "Mr.",
                    HireDate = new DateTime(2023, 12, 1),
                    Address = "Madevej 9",
                    City = "Aabenraa",
                    PostalCode = "6200",
                    Extension = "0747",
                    HomePhone = "33344901"
                },
                new Employee()
                {
                    LastName = "Sørensen",
                    FirstName = "Kenneth",
                    TitleOfCourtesy = "Mr.",
                    HireDate = new DateTime(2023, 12, 1),
                    Address = "Boulevarden",
                    City = "Vejle",
                    PostalCode = "7100",
                    Extension = "0748",
                    HomePhone = "33344901"
                }
            };

            //context.Employees.AddRange(insert2);

            var insert3 = new Product()
            {
                ProductName = "SuperDuperBeer",
                QuantityPerUnit = "1 Piece",
                UnitPrice = 100,
                UnitsInStock = 0,
                UnitsOnOrder = 10,
                ReorderLevel = 0,
                Discontinued = false,
            };


            //context.Products.Add(insert3);

            var insert4 = new Supplier()
            {
                CompanyName = "Campus Vejle",
                ContactName = "Jonas Beck",
                ContactTitle = "Sales Representative",
                Address = "Boulevarden 21",
                City = "Vejle",
                PostalCode = "7100",
                Country = "Denmark",
                Phone = "(45)12345678"
            };

            //context.Suppliers.Add(insert4);

            var insert5 = context.Products.Where(product => product.ProductName == "SuperDuperBeer").FirstOrDefault();

            var supplier5 = context.Suppliers.Where(supplier => supplier.SupplierId == 1030).FirstOrDefault();

            insert5.Supplier = supplier5;

            var insert6 = new Shipper()
            {
                CompanyName = "Mærsk",
                Phone = "(45)12345678"
            };

            //context.Shippers.Add(insert6);


            // JOINS

            var joins1 = context.Territories.Select(territory => new
            {
                territory.TerritoryDescription,
                territory.Region.RegionDescription
            });


            var joins2 = context.Products.Where(product => product.Category.CategoryName == "Beverages" && product.Discontinued == false)
                                         .Select(product => new
                                         {
                                             product.ProductName,
                                             product.UnitPrice,
                                             product.UnitsInStock
                                         })
                                         .OrderBy(product => product.UnitsInStock)
                                         .ThenBy(product => product.ProductName);


            var joins3 = context.Orders.Where(order => order.OrderDate.Value.Month == 2 && order.OrderDate.Value.Year == 1997)
                                       .OrderBy(order => order.OrderDate)
                                       .ThenBy(order => order.Customer.CompanyName)
                                       .Select(order => order.Customer.CompanyName);


            var joins4 = context.Orders.Where(order => (order.OrderDate.Value.Month >= 3 && order.OrderDate.Value.Month <= 6) && order.OrderDate.Value.Year == 1997)
                                       .OrderBy(order => order.OrderDate)
                                       .ThenBy(order => order.Customer.CompanyName)
                                       .Select(order => new
                                       {
                                           order.Customer.CompanyName,
                                           order.ShippedDate
                                       });


            // Only 8 matches
            var joins5 = context.Products.Where(products => products.Category.CategoryName == "Beverages")
                                         .Select(product => product.Supplier.CompanyName)
                                         .Distinct();


            var joins6 = context.Employees.Select(employee => new
            {
                employee.FirstName,
                employee.LastName,
                Boss = context.Employees.Where(boss => boss.EmployeeId == employee.ReportsTo)
                                        .Select(boss => new
                                        {
                                            boss.FirstName,
                                            boss.LastName,
                                        })
                                        .FirstOrDefault()
            }).OrderBy(employee1 => employee1.Boss.FirstName);


            foreach (var item in joins6)
            {
                Console.WriteLine(" {0,-15} {1,-15} {2,-15} {3,-15}", item.FirstName, item.LastName, item.Boss?.FirstName, item.Boss?.LastName);
            }


            context.SaveChanges();





            /* 8.4
             
            
             
            // 8.4 4 Test

            var employees = context.Employees.ToList();
            Console.WriteLine("\nEmployees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            // 8.4 5 Insert
            Supplier s = new()
            {
                CompanyName = "MySoftware",
                ContactTitle = "Head of heads",
                ContactName = "Kevin Magnussen",
                Address = "Forløkken 47",
                PostalCode = "1024",
                City = "Bitstrup",
                Country = "Computerland"
            };


            context.Suppliers.Add(s);
            context.SaveChanges();

            Console.WriteLine("\nSuppliers:");
            foreach (Supplier supplier in context.Suppliers.ToList())
            {
                Console.WriteLine($"{supplier.CompanyName}");
            }

            // 8.4 6 Update
            Supplier supplierToUpdate = context.Suppliers.SingleOrDefault(s => s.CompanyName == "MySoftware");
            supplierToUpdate.CompanyName = "Mega Soft";
            context.SaveChanges();


            Console.WriteLine("\nSuppliers:");
            foreach (Supplier supplier in context.Suppliers.ToList())
            {
                Console.WriteLine($"{supplier.CompanyName}");
            }

            // 8.4 7 Delete
            Supplier supplierToRemove = context.Suppliers.SingleOrDefault(s => s.CompanyName == "MEGA SOFT");
            context.Suppliers.Remove(supplierToRemove);
            context.SaveChanges();

            Console.WriteLine("\nSuppliers:");
            foreach (Supplier supplier in context.Suppliers.ToList())
            {
                Console.WriteLine($"{supplier.CompanyName}");
            }

            */

        }

    }
}