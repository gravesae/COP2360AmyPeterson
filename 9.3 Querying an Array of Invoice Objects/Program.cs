using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_Querying_an_Array_of_Invoice_Objects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Invoice[] invoices = {
                new Invoice(83, "Electric sander", 7, 7.98M),
                new Invoice(24, "Power saw", 18, 99.99M),
                new Invoice(7, "Sledge hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn mower", 3, 79.50M),
                new Invoice(68, "Screwdriver", 106, 6.99M),
                new Invoice(56, "Jig saw", 21, 11.00M),
                new Invoice(3, "Wrench", 34, 7.50M),};

            // display all employees
            Console.WriteLine("Original Array:");
            foreach (var invoice in invoices)
                Console.WriteLine(invoice);

            // order the invoices by part description
            var partDescriptionSort =
                from i in invoices
                orderby i.PartDescription
                select i;

            // display all invoices sorted by part description
            Console.WriteLine("\nSorted by Part Description:");
            foreach (var invoice in partDescriptionSort)
                Console.WriteLine(invoice);

            // order the invoices by price
            var priceSort =
                from i in invoices
                orderby i.Price
                select i;

            // display all invoices sorted by price
            Console.WriteLine("\nSorted by Price:");
            foreach (var invoice in priceSort)
                Console.WriteLine(invoice);

            // use LINQ to select PartDescription and Quanity and sorted by Quanity
            var quantitySort =
                from i in invoices
                orderby i.Quantity
                select new {i.PartDescription, i.Quantity };

            // display only the Part Description and Quanity for all invoices
            Console.WriteLine("\nPart Descriptions Sorted by Quanity:");
            foreach (var invoice in quantitySort)
                Console.WriteLine(invoice);

            // use LINQ to select PartDescription and InvoiceTotal, where InvoiceTotal = value and let value = quanity * price
            var valueSort =
                from i in invoices
                let value = i.Quantity * i.Price 
                orderby value
                select new {i.PartDescription, InvoiceTotal = value};

            // display only the Part Description and InvoiceTotal for all invoices
            Console.WriteLine("\nPart Descriptions Sorted by Invoice Value (Quanity * Price):");
            foreach (var invoice in valueSort)
                Console.WriteLine(invoice);    

            // filter a range the InvoiceTotal between $200-$500
            var invoiceRange = 
                from i in valueSort
                where i.InvoiceTotal >= 200 && i.InvoiceTotal <= 500
                select i;

            // display only the invoices where the InvoiceTotal is between $200-$500
            Console.WriteLine("\nInvoices between $200-$500");
            foreach (var invoice in invoiceRange)
                Console.WriteLine(invoice);            
        }
    }
}
