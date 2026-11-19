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

        
        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            switch (salesInitial.Trim().ToUpper())
            {
                case "D":
                    danielleTotal += salesAmount;
                    lblDisplay.Text = "Sale recorded for Danielle: " + salesAmount.ToString("N2")
                        + "\nDanielle's running total: " + danielleTotal.ToString("N2");
                    break;

                case "E":
                    edwardTotal += salesAmount;
                    lblDisplay.Text = "Sale recorded for Edward: " + salesAmount.ToString("N2")
                        + "\nEdward's running total: " + edwardTotal.ToString("N2");
                    break;

                case "F":
                    fatimaTotal += salesAmount;
                    lblDisplay.Text = "Sale recorded for Fatima: " + salesAmount.ToString("N2")
                        + "\nFatima's running total: " + fatimaTotal.ToString("N2");
                    break;

                default:
                    lblDisplay.Text = "Invalid salesperson initial! Use D, E, or F only.";
                    break;
            }
        }

        
        private void clearEntry()
        {
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
                lblDisplay.Text = "Please fill in both fields.";
                return;
            }

            if (!double.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                lblDisplay.Text = "Please enter a valid amount of sale.";
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
