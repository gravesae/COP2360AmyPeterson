// Assignemtn 4:10: GradeBookTest.cs
// Create and manipulate a GradeBook object.
using System;

public class GradeBookTest
{
    // Main method begins program execution.
    public static void Main(string[]args)
    {
       // create a GradeBook object and assign it to myGradeBook
       GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming", "April Graves");

       // display initial value of CourseName
       Console.WriteLine("Initial course name is: '{0}'", myGradeBook.CourseName);

       // prompt for and input course name
       Console.WriteLine("Please enter the course name:");
       myGradeBook.CourseName = Console.ReadLine(); // set CourseName
       Console.WriteLine(); // output a blank line

       // display welcome message after specifiying course name
       myGradeBook.DisplayMessage();

    } // end Main
} // end class GradeBookTest