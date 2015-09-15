// Assignment 4.10: GradeBook.cs
// GradeBook class with a constructor to initialize the course name.

using System;

public class GradeBook
{
    // auto-implemented property CourseName implicity created an
    // instance variable for this GradeBook's course name
    public string CourseName { get; set; }

    // auto-implemented property Instructor name implicity created an
    // instance variable for this GradeBook's instructor 
    public string InstructorName { get; set; }

    // constructor initializes auto-implemented property
    // CourseName with string supplied as argument
    public GradeBook(string courseName, string instructorName)
    {
        CourseName = courseName ; // set CourseName to courseName
        InstructorName = instructorName; // set InstructorName to instructorName
    } // end constructor

    // display a welcome message to the GradeBook user
    public void DisplayMessage()
    {
        // use auto-implemented property CourseName to get the
        // name of teh course that this GradeBook represents
        Console.WriteLine("Welcome to the grade book for \n{0}!", CourseName);
        // use auto-impleted propety InstructorName to get the name of the instructor
        Console.WriteLine("This course is presented by: {0}", InstructorName);
    } // end method DisplayMessage
} // end Class GradeBook