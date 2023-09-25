namespace Ex_0903
{
    internal class Program_0903
    {
        static void Main(string[] args)
        {
            var invoices = new[]
            {
                new Invoice(83, "Electric sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "Sledge hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn mower", 3, 79.50M),
                new Invoice(68, "Screwdriver", 106, 6.99M),
                new Invoice(56, "Jig saw", 21, 11M),
                new Invoice(3, "Wrench", 34, 7.50M)
            };

            // Exercise A
            var SortPartDesc =
                from invoice in invoices
                orderby invoice.PartDescription
                select invoice;

            Console.WriteLine("Invoices Sorted by Part Description");
            foreach (var invoice in SortPartDesc)
            {
                Console.WriteLine(invoice.ToString());
            }

            // Exercise B
            var SortPrice =
                from invoice in invoices
                orderby invoice.Price
                select invoice;

            Console.WriteLine();
            Console.WriteLine("Invoices Sorted by price");
            foreach (var invoice in SortPrice)
            {
                Console.WriteLine(invoice.ToString());
            }

            // Exercise C
            var SortQuantity =
                from invoice in invoices
                orderby invoice.Quantity
                select new { invoice.PartDescription, invoice.Quantity };

            Console.WriteLine();
            Console.WriteLine("Invoices Sorted by quantity (Select only PartDescription and Quantity)");
            foreach (var invoice in SortQuantity)
            {
                Console.WriteLine($"{invoice.PartDescription,-20} {invoice.Quantity,-5}");
            }

            // Exercise D
            var SortInvoiceTotal =
                from invoice in invoices
                let InvoiceTotal = invoice.Quantity * invoice.Price
                orderby InvoiceTotal
                select new { invoice.PartDescription, InvoiceTotal };

            Console.WriteLine();
            Console.WriteLine("Invoices Sorted by InvoiceTotal (Select only Partdescription and InvoiceTotal)");
            foreach (var invoice in SortInvoiceTotal)
            {
                Console.WriteLine($"{invoice.PartDescription,-20} {invoice.InvoiceTotal,-5}");
            }

            // Exercise E
            var sortInvoiceTotal200_500 =
                from invoice in SortInvoiceTotal
                where (invoice.InvoiceTotal >= 200) && (invoice.InvoiceTotal <= 500)
                select invoice;

            Console.WriteLine();
            Console.WriteLine("Invoices from SortInvoiceTotal with InvoiceTotal between 200 and 500");
            foreach (var invoice in sortInvoiceTotal200_500)
            {
                Console.WriteLine($"{invoice.PartDescription,-20} {invoice.InvoiceTotal,-5}");
            }






        }
    }
}