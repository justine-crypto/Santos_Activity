using System;
using System.Drawing;
using System.Windows.Forms;

namespace Santos_Activity
{
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward, double fatima)
        {
            BuildUI(danielle, edward, fatima);
        }

        private string FormatMoney(double value)
        {
            return "$" + value.ToString("#,0.##");
        }

        private Label AddLabel(string text, int x, int y, float size, bool bold)
        {
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = text;
            lbl.Font = new Font("Microsoft Sans Serif", size, bold ? FontStyle.Bold : FontStyle.Regular);
            lbl.Location = new Point(x, y);
            this.Controls.Add(lbl);
            return lbl;
        }

        private void BuildUI(double danielle, double edward, double fatima)
        {
            double grandTotal = danielle + edward + fatima;

            this.Text = "Summary Report";
            this.ClientSize = new Size(507, 330);
            this.StartPosition = FormStartPosition.CenterParent;

            
            Label title = AddLabel("SUMMARY REPORT", 0, 20, 20F, true);
            title.AutoSize = false;
            title.Size = new Size(this.ClientSize.Width, 40);
            title.TextAlign = ContentAlignment.MiddleCenter;

            
            AddLabel("Danielle Total Sales :   " + FormatMoney(danielle), 40, 90, 12F, false);
            AddLabel("Edward Total Sales :   " + FormatMoney(edward), 40, 130, 12F, false);
            AddLabel("Fatima Total Sales :   " + FormatMoney(fatima), 40, 170, 12F, false);
            AddLabel("Total Sales      " + FormatMoney(grandTotal), 40, 230, 15F, true);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(405, 391);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }
    }
}