using System;

namespace TabularOutput
{
    class TabularProcess
    {
        static void Main(string[] args)
        {
            int number;     // variable for the the number
            int finish = 5; // what number we are ending with
          
            number = 1; // start with the number 1
            Console.WriteLine("N\t10*N\t100*N\t1000*N"); // Heading for table

            while (number <= finish) // create loop until you finish
            {
                // Create a table of a number number * 10, number * 100, number * 1000
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", number, number * 10, number * 100, number * 1000);
                number++; // add the by 1 each time
            } // end loop

        } // end main
    } // end Class
}
