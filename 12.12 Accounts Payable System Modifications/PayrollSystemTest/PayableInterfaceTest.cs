using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Grade: 9.5
//Observations
//It is not the best design to add the bonus to the BasePlusCommisionEmployee classes GetPaymentAmount because the bonus would always be added when that method was called, even if they should not get the bonus.
//It is also not clear to other users of this class that a bonus is being added.
//The more appropriate design would be to create a GetPayWithBonus or some such method and then to check for type BasePlusCommisionEmployee when processing payroll and call the GetPayWithBonus method.
//This way the bonus is explicitly being added and GetPaymentAmount will always reflect the true payment amount which should not include a bonus.
public class PayableInterfaceTest
{
    public static void Main(string [] args)
    {
        // create four-element IPayable array
        IPayable[] payableObjects = new IPayable[6];

        // populate array with objects that implement IPayable
        payableObjects[0] = new Invoice("01234", "seat", 2, 375.00M);
        payableObjects[1] = new Invoice("56789", "tire", 4, 79.95M);
        payableObjects[2] = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
        payableObjects[3] = new HourlyEmployee("Bob", "Bobson", "222-22-2222", 16.75M, 40M );
        payableObjects[4] = new CommissionEmployee("Sally", "Seashore", "333-33-3333", 10000M, .06M );
        payableObjects[5] = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000M, .04M, 300M, .1M);

        Console.WriteLine("Invoices and Employees process polymorphically:\n");

        // generically process each element in array payableObjects
        foreach (var currentPayable in payableObjects)
        {
            // output currentPayable and its appropriate payment amount
            Console.WriteLine("{0}\npayment due: {1:C}\n", currentPayable, currentPayable.GetPaymentAmount());
        } // end foreach
    } // end Main
} // end class PayableInterfaceTest
