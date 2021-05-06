using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
   

    public partial class Form1 : Form
    {
        //declare variables 
        double sum = 0;
        double counter = 0;
        double currentNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //check to see if a number has been entered, if not, diplay error message
            try
            {
                currentNumber = Convert.ToDouble(inputBox.Text);
                outputLabel.Visible = true;

                //check if the number is greater than or equal to zero. If it is, add to sum, if not, find the average
                if (currentNumber > 0)
                {
                    outputLabel.Text = $"{currentNumber} was added";
                    sum = currentNumber + sum;
                    counter = counter + 1;
                }
                else
                {
                    sum = sum / counter;
                    outputLabel.Text = $"The average is of the entered numbers is: {sum}";
                }
            }
            catch
            {
                outputLabel.Text = "please eneter a number";
            }


          
       

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resest variables and text
            sum = 0;
            counter = 0;
            currentNumber = 0;
            outputLabel.Visible = false;
            inputBox.Text = "0"; 
        }
    }
}
