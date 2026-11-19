using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santos_Activity
{
    public partial class Form1 : Form
    {

        private double danielleTotal = 0;
        private double edwardTotal = 0;
        private double fatimaTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private string FormatMoney(double value)
        {
            return "$" + value.ToString("#,0.##");
        }

        
        private void ShowRecorded(string name, double amount, double total)
        {
            lblDisplay.ForeColor = Color.FromArgb(30, 120, 60);
            lblDisplay.Text = FormatMoney(amount) + " in sales has been successfully recorded for " + name + ","
                + "\nBringing his/her total sales to " + FormatMoney(total);
        }

        
        private void ShowError(string message)
        {
            lblDisplay.ForeColor = Color.Red;
            lblDisplay.Text = message;
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            switch (salesInitial.Trim().ToUpper())
            {
                case "D":
                    danielleTotal += salesAmount;
                    ShowRecorded("Danielle", salesAmount, danielleTotal);
                    break;

                case "E":
                    edwardTotal += salesAmount;
                    ShowRecorded("Edward", salesAmount, edwardTotal);
                    break;

                case "F":
                    fatimaTotal += salesAmount;
                    ShowRecorded("Fatima", salesAmount, fatimaTotal);
                    break;

                default:
                    ShowError("Invalid salesperson initial! Use D, E, or F only.");
                    break;
            }
        }


        private void clearEntry()
        {
            
            danielleTotal = 0;
            edwardTotal = 0;
            fatimaTotal = 0;

            
            txtInitial.Clear();
            txtAmount.Clear();
            lblDisplay.Text = "";
            txtInitial.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            double amount;

            if (txtInitial.Text.Trim() == "" || txtAmount.Text.Trim() == "")
            {
                ShowError("Please fill in both fields.");
                return;
            }

            if (!double.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                ShowError("Please enter a valid amount of sale.");
                return;
            }

            getSalesPerson_Amount(txtInitial.Text, amount);


            txtInitial.Clear();
            txtAmount.Clear();
            txtInitial.Focus();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            
            if (danielleTotal + edwardTotal + fatimaTotal == 0)
            {
                ShowError("No sales recorded yet. Nothing to print.");
                return;
            }

            Form2 summary = new Form2(danielleTotal, edwardTotal, fatimaTotal);
            summary.ShowDialog();
        }

        private void txtInitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }

}