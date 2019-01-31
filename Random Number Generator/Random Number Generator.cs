using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            bool numberOne = Int32.TryParse(numberOneTbox.Text, out num1);
            bool numberTwo = Int32.TryParse(numberTwoTbox.Text, out num2);
            if (numberOne && numberTwo)
            {
                Randomiser randomiser = new Randomiser();
                randomiser.GenerateNumber(num1, num2);
                MessageBox.Show("Your Number is: " + Convert.ToString(randomiser.GetNumber()), "Success");
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!", "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
