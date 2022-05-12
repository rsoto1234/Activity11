using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //object of Dice class with same number of sides
        Dice dice1 = new Dice(5);
        Dice dice2 = new Dice(5);
        //This variable stores number of rolls
        int numberOfRolls = 0;
        //Button click event for Roll Dice
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            //call method rollDie()
            int roll1 = dice1.rollDie();
            int roll2 = dice2.rollDie();
            //show dice face on the labels
            lblDice1.Text = roll1.ToString();
            lblDice2.Text = roll2.ToString();
            //increment the value of numberOfRolls
            numberOfRolls++;
            //checking for the snake eyes
            if (roll1 == 1 && roll2 == 1)
            {
                //when double 1's on the die face then
                //disable button
                btnRollDice.Enabled = false;
                //show MessageBox
                MessageBox.Show("It took " + numberOfRolls + " rolls to get snake eyes!");
            }
        }//enf for button click
    }
    //C# class
    class Dice
    {
        //A private field for the number of sides of the die
        private int numberOfSides;
        // constructor that takes an integer between 4 and 20, inclusive and sets the number of sides of the die
        public Dice(int numbeSides)
        {
            //checking number of sides
            if (numbeSides >= 4 && numbeSides <= 20)
            {
                //when numbeSides between 4 to 20 inclusive then
                numberOfSides = numbeSides;
            }
            else
            {
                //when invalid sides are entered then
                MessageBox.Show("Number of sides should be between 4 to 20 inclusive");
            }
        }//end of Constructor
         //A method, rollDie(), returns the face value when the die is rolled
        public int rollDie()
        {
            //Object of Random class
            Random randomDie = new Random();
            //a Random number to “roll” the die
            return randomDie.Next(1, numberOfSides);
        }//end of method rollDie()
    }//end of class Dice
}