using System;

// Declare Invoice Test
public class InvoiceTest
{
    // Entry point to the application
    public static void Main(string[] args)
    {
        // Intialize the invoice
        Invoice invoice1 = new Invoice("1234", 50, 9.89M, "Sheetrock 4ft x 8ft");
        Console.WriteLine("Part Number: {0}", invoice1.PartNumber);  // Print part number
        Console.WriteLine("Quantity: {0}", invoice1.Quantity);  // Print quanity
        Console.WriteLine("Price Per Item: {0:C}", invoice1.PricePerItem);  // Print price per item
        Console.WriteLine("Description: {0}", invoice1.Description);  // Print description
        Console.WriteLine("Invoice Amount: {0:C}", invoice1.GetInvoiceAmount());   // Print the invoice amount total
    } // End Method main
} // End class InvoiceTest
