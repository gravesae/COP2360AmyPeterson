using System;

// Declare Invoice Class

//Grade 10/10 - Great job
public class Invoice
{    
    private int _quantity; // Quanity variable
    private decimal _pricePerItem; // Price Per Item variable
    
    public string PartNumber {get; set;} // Part number property

    public int Quantity // Quanity property
    {
        get
        {
            return _quantity;
        } 
        set
        {
            if (value >= 0) // Only update quantiy if it is a positive number
            _quantity = value;
        } 
    }
    public decimal PricePerItem // Price Per Item property
    {
        get
        {
            return _pricePerItem;
        } 
        set
        {
            if (value >= 0) // Only update price per item if it is a positive number
            _pricePerItem = value;
        } 

    }
    public string Description { get; set; } // Description property
       
    // The method for calculating the invoice amount
    public decimal GetInvoiceAmount()
    {
        // Convert the formula to a decimal
        return Convert.ToDecimal(Quantity*PricePerItem);
    }

    // Constructor to intialize the invoice
    public Invoice(string partNumber, int quantity, decimal pricePerItem, string description)
    {
        PartNumber = partNumber; // Setting the part number
        Quantity = quantity; // Setting the quantity
        PricePerItem = pricePerItem; // Setting the price per item
        Description = description; // Setting the description
    }
} // end Class Invoice



   
