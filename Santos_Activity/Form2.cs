using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Santos_Activity
{
    public partial class Form2 : Form
    {
        private Label lblSummary;

        public Form2(double danielle, double edward, double fatima)
        {
            InitializeComponent();

            double grandTotal = danielle + edward + fatima;

            lblSummary.Text = "SALES SUMMARY REPORT\n\n"
                + "Danielle : " + danielle.ToString("N2") + "\n"
                + "Edward   : " + edward.ToString("N2") + "\n"
                + "Fatima   : " + fatima.ToString("N2") + "\n"
                + "-------------------------\n"
                + "Total    : " + grandTotal.ToString("N2");
        }

        private void InitializeComponent()
        {
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(51, 65);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(92, 32);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "label1";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(507, 495);
            this.Controls.Add(this.lblSummary);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}