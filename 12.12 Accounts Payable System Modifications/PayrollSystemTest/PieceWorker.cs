using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PieceWorker : Employee
{
    private int pieces;
    private decimal wage;

    // five-parameter constructor
    public PieceWorker(string first, string last, string ssn, decimal wage, int pieces) 
        : base(first, last, ssn)
    {
        Wage = wage; // validate wage via property
        Pieces = pieces; // validate pieces via property
    }

    public decimal Wage
    {
        get
        {
            return wage;
        }
        set
        {
            if (value >= 0) // validation
                wage = value;
            else
                throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >=0");
        }
    }

    public int Pieces
    {
        get
        {
            return pieces;
        }
        set
        {
            if (value >= 0) // validation
                pieces = value;
            else
                throw new ArgumentOutOfRangeException("Pieces", value, "Pieces must be >=0");
        }
    }

    // calculate earnings; implement interface IPayable method
    // that was abstract in base class Employee
    public override decimal GetPaymentAmount()
    {
        return Wage * Pieces;
    }
    
    // return string representation of PieceWorker object
    public override string ToString()
    {
        return string.Format("piece worker employee: {0}\n{1}: {2}; {3}: {4:C}", 
            base.ToString(), "pieces made", Pieces, "wage per piece", Wage);
    }
}

