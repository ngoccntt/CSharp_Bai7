using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPT.Text = "ax" + ("\u00B2") + " + bx + c = 0";
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;

            }

            trbsoA.Value = Convert.ToInt32(txtsoA.Text);
            trbsoB.Value = Convert.ToInt32(txtsoB.Text);
            trbsoC.Value = Convert.ToInt32(txtsoC.Text);
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            int intA, intB, intC;
            double delta, x1, x2;
            intA = Convert.ToInt32(txtsoA.Text);
            intB = Convert.ToInt32(txtsoB.Text);
            intC = Convert.ToInt32(txtsoC.Text);



            string strB = (intB < 0) ? " - " + Math.Abs(intB) : " + " + Math.Abs(intB);
            string strC = (intC < 0) ? " - " + Math.Abs(intC) : " + " + Math.Abs(intC);



            lblPT.Text = intA + "x" + ("\u00B2") + strB + "x" + strC + " = 0";

            if (intA == 0)
            {
                giaiPTbac1(intB, intC, lblKQ);
            }
            else
            {
                delta = (double)Math.Pow(intB, 2) - 4 * intA * intC;
                lblKQ.Text = "Delta = " + Convert.ToString(delta) + "\n";
                if (delta < 0)
                {
                    lblKQ.Text += "Phương trình vô nghiệm\n";
                }
                if (delta == 0)
                {
                    lblKQ.Text += "Phương trình có nghiệm kép x1 = x2 = " + (double)(-intB / (2 * intA)) + "\n";

                }
                if (delta > 0)
                {
                    x1 = (double)(-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (double)(-intB - Math.Sqrt(delta)) / (2 * intA);
                    lblKQ.Text += "Phương trình có 2 nghiệm\n";
                    lblKQ.Text += "x1 = " + x1 + "\n";
                    lblKQ.Text += "x2 = " + x2 + "\n";
                }
            }






        }
        private void khiDiChuot(object sender, EventArgs e)
        {
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;


            }
        }

        private void trbSoA_Scroll(object sender, EventArgs e)
        {
            txtsoA.Text = trbsoA.Value.ToString();
        }

        private void trbSoB_Scroll(object sender, EventArgs e)
        {
            txtsoB.Text = trbsoB.Value.ToString();
        }

        private void trbSoC_Scroll(object sender, EventArgs e)
        {
            txtsoC.Text = trbsoC.Value.ToString();
        }

        static void giaiPTbac1(int intA, int intB, Control lblKQinFunction)
        {
            lblKQinFunction.Text = "";
            if (intA == 0 && intB == 0)
            {
                lblKQinFunction.Text = "Phương trình có vô số nghiệm\n";
            }
            else if (intA == 0 && intB != 0)
            {
                lblKQinFunction.Text = "Phương trình vô nghiệm\n";
            }
            else
            {
                lblKQinFunction.Text = "Phương trình có 1 nghiệm duy nhất x = " + ((double)-intB / intA) + "\n";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        { }
    }
}