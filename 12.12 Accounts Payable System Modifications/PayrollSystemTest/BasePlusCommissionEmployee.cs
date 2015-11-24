// Fig. 12.8: BasePlusCommissionEmployee.cs
// BasePlusCommissionEmployee class that extends CommissionEmployee.
using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
   private decimal baseSalary; // base salary per week
   private decimal bonusPercentage; 

   // six-parameter constructor
   public BasePlusCommissionEmployee( string first, string last,
      string ssn, decimal sales, decimal rate, decimal salary, decimal bonus )
      : base( first, last, ssn, sales, rate )
   {
      BaseSalary = salary; // validate base salary via property
      bonusPercentage = bonus;
   } // end six-parameter BasePlusCommissionEmployee constructor

   // property that gets and sets 
   // base-salaried commission employee's base salary
   public decimal BaseSalary
   {
      get
      {
         return baseSalary;
      } // end get
      set
      {
         if ( value >= 0 )                                       
            baseSalary = value;                                  
         else                                                    
            throw new ArgumentOutOfRangeException( "BaseSalary", 
               value, "BaseSalary must be >= 0" );               
      } // end set
   } // end property BaseSalary
    
    public decimal PaymentAmount
   {
       get 
       {
           return BaseSalary + base.GetPaymentAmount();
       }
   }

    public decimal BonusAmount
    {
        get
        {
            return PaymentAmount * bonusPercentage;
        }
    }
   // calculate earnings; implement interface IPayable method
   // that was abstract in base class Employee
   public override decimal GetPaymentAmount()
   {
       return PaymentAmount + BonusAmount;
   } // end method GetPaymentAmount               

   // return string representation of BasePlusCommissionEmployee object
   public override string ToString()
   {
      return string.Format( "base-salaried {0}; base salary: {1:C}; bonus: {2:C}",
         base.ToString(), BaseSalary, BonusAmount);
   } // end method ToString                                            
} // end class BasePlusCommissionEmployee

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/