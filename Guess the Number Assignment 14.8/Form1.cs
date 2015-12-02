using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Grade: 10
// All requirements have been met, great job implemnting the warmer, colder logic
namespace Guess_the_Number_Assignment_14._8
{
    public partial class Form1 : Form
    {
        int previousGuess; // Store the previous guess
        int currentGuess; // Store the current guess
        int answer; // The generated number
        Random random = new Random(); // Random number generator

        public Form1() // Default constructor
        {
            InitializeComponent(); 
        } // End constructor

        private void Form1_Load(object sender, EventArgs e) //Begin method Form1_Load
        {
            NewGame(); //Call method NewGame when form loads
        } // End method Form1_Load

        private void btnGuess_Click(object sender, EventArgs e) //Begin method btnGuess_Click
        {
            SubmitGuess(); //Call method SubitGuess
        } //End method btnGuess_Click

        private void SubmitGuess() //Begin method for SubmitGuess
        {
            currentGuess = int.Parse(txtGuess.Text); //Convert user's guess from text to an int
            if (currentGuess < answer) //If statement to determine whether guess is too low
            {
                lblResult.Text = "Too Low"; //The result will be labeled too low if current guess > answer
            }
            else if (currentGuess > answer) //Else If statement to determine whether guess is too high
            {
                lblResult.Text = "Too High"; //The result will be labeled too low if current guess < answer
            }
            else //Else statement, it not too low or too high, guess must be correct
            {
                lblResult.Text = ""; //The label does not need to be shown
                BackColor = Color.Green; //Change form color to green.
                txtGuess.BackColor = Color.White; //Change the textbox txtGuess color back to white
                txtGuess.Enabled = false; //Disable the textbox txtGuess so the user cannot continue to enter any more numbers
                btnGuess.Enabled = false; //Disable the btnGuess so the user cannot continue to enter new numbers
                MessageBox.Show("Correct!"); //Display a message box that says Correct
                return; //Stop processing the method btnGuess_Click
            } 

            if (previousGuess != 0) //If statement to determine if they are warmer(red) or colder(blue)
            {
                int previousDifference = Math.Abs(previousGuess - answer); //Calculate the absolute value of the difference between the previous answer and the guess
                int currentDifference = Math.Abs(currentGuess - answer); //Calculate the absolute value of the difference between the current answer and the guess
                if (currentDifference > previousDifference) //If statement if the current answer is farther away to the answer than the previous answer
                {
                    txtGuess.BackColor = Color.RoyalBlue; //Change the textbox txtGuess to Royal Blue to represent colder
                }
                else //If statement if the current answer is equal to or closer to the answer than the previous answer
                {
                    txtGuess.BackColor = Color.Red; //Change the textbox txtGuess to Red to represent warmer
                }
            } //End method SubmitGuess            
            txtGuess.SelectAll(); //Select all text in the textbox txtGuess
            previousGuess = currentGuess; //Change the current guess to the previous guess
        } //End method SubmitGuess

        private void btnNewGame_Click(object sender, EventArgs e) //Begin method btnNewGame_Click
        {
            NewGame(); //Call method NewGame
        } //End method btnNewGame_Click

        private void NewGame() //Begin method NewGame
        {
            answer = random.Next(1, 1001); //Generate a random number between 1-1000
            BackColor = Color.WhiteSmoke; //Revert the background color to WhiteSmoke
            btnGuess.Enabled = true; //Enable the button to allow user to be guessing
            txtGuess.Enabled = true; //Enable the textbox txtGuess to allow user to enter guess
            txtGuess.BackColor = Color.White; //Revert the background color to white for beginning number
            txtGuess.Clear(); //Clear the textbox txtGuess guess   
            txtGuess.Select(); //Set focus to the textbox txtGuess
        } //End method NewGame

        private void txtGuess_KeyDown(object sender, KeyEventArgs e) //Call method txtGuess_KeyDown
        {
            if (e.KeyCode == Keys.Enter) //Allow the user to use the enter key to submit guess, in addition to the mouse
            {
                SubmitGuess(); //Call method SubmitGuess
            }
        }  //End method txtGuess_KeyDown
    } //End class
} //End namespace Guess_the_Number_Assignment_14._8
