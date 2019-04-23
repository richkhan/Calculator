using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class CalculatorForm : Form
    {
        /****************************************************************************
         <project firstname="Richard" lastname="Khan" projname="MEMORYCALCULATOR"/>
         ****************************************************************************/
        /// <summary>
        /// This project is a simple calculator that allows for addition, subtraction, 
        /// multiplication, and divide. It also saves the numbers in memory that are there. 
        /// </summary>


        MemoryCalculator memCalculator;

        public CalculatorForm()
        {
            InitializeComponent();
            memCalculator = new MemoryCalculator();
        }

        #region NORMAL BUTTONS

        private void numBtn_Click(object sender, EventArgs e)
        {
            if (memCalculator.OpPressed() == true)
            {
                txtDisplay.Text = "";
                memCalculator.SetHasOperand2(true);
                memCalculator.SetOpPressed(false);
            }
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            memCalculator.Add(decimal.Parse(txtDisplay.Text));
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (memCalculator.HasOperand2())
            {
                if (memCalculator.OpPressed() == false)
                {
                    memCalculator.Equals(decimal.Parse(txtDisplay.Text));
                    memCalculator.SetOpPressed(true);
                }
                else
                {
                    memCalculator.Equals();
                }
                txtDisplay.Text = "";
                txtDisplay.Text = memCalculator.CurrentValue.ToString();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            memCalculator.Divide(decimal.Parse(txtDisplay.Text));
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            memCalculator.Subtract(decimal.Parse(txtDisplay.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            memCalculator.Clear();
            txtDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            memCalculator.Multiply(decimal.Parse(txtDisplay.Text));
        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region MEMORY BUTTONS

        private void btnMS_Click(object sender, EventArgs e)
        {
            memCalculator.CurrentValue = decimal.Parse(txtDisplay.Text);
            memCalculator.MemoryStore();
            lblMemory.Text = memCalculator.CurrentValue.ToString();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            memCalculator.MemoryRecall();
            txtDisplay.Text = memCalculator.MemoryValue.ToString();
            memCalculator.SetHasOperand2(true);
            memCalculator.SetOpPressed(false);
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            memCalculator.MemoryAdd(decimal.Parse(txtDisplay.Text));
            lblMemory.Text = memCalculator.MemoryValue.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memCalculator.MemoryClear();
            lblMemory.Text = memCalculator.MemoryValue.ToString();
        }

        #endregion

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            frmAboutMe f = new frmAboutMe ();
            this.Hide(); //Hide Main form
            f.ShowDialog();
            this.Show(); //show main form
        }

       
    }
}
