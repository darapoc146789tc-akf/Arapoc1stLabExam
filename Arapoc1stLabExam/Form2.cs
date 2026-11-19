using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arapoc1stLabExam
{
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward, double fatima)
        {
            InitializeComponent();

            double grandTotal = danielle + edward + fatima;

            lbl_Danielle.Text = "Danielle: ₱" + danielle.ToString("F2");
            lbl_Edward.Text = "Edward: ₱" + edward.ToString("F2");
            lbl_Fatima.Text = "Fatima: ₱" + fatima.ToString("F2");
            lbl_Total.Text = "Grand Total: ₱" + grandTotal.ToString("F2");
        }

        private void Sum_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
