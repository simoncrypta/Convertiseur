using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int icpt = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            icpt = 1;
            label1.Text = "Livres";
            label3.Text = "Kilos";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            icpt = 2;
            label1.Text = "Kilos";
            label3.Text = "Livres";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            icpt = 3;
            label1.Text = "Fahrenheit";
            label3.Text = "Celsius";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            icpt = 4;
            label1.Text = "Celsius";
            label3.Text = "Fahrenheit";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            icpt = 5;
            label1.Text = "Mètres";
            label3.Text = "Pieds";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            icpt = 6;
            label1.Text = "Pieds";
            label3.Text = "Mètres";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            icpt = 7;
            label1.Text = "Cm";
            label3.Text = "Pouce";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            icpt = 8;
            label1.Text = "Pouce";
            label3.Text = "Cm";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            icpt = 9;
            label1.Text = "Litre";
            label3.Text = "Gallons";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            icpt = 10;
            label1.Text = "Gallons";
            label3.Text = "Litre";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double iNb =0;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            bool res = Double.TryParse(textBox1.Text, out iNb);
            if (res == false)
            {
                MessageBox.Show("Erreur : entrer un chiffre valide.");
            }

            switch(icpt)
            {
                case 1:
                    label4.Text = Convert.ToString(Math.Round(iNb / 2.2046, 2));
                    break;
                case 2:
                    label4.Text = Convert.ToString(Math.Round(iNb * 2.2046, 2));
                    break;
                case 3:
                    label4.Text = Convert.ToString(Math.Round((iNb - 32) * 5 / 9, 2));
                    break;
                case 4:
                    label4.Text = Convert.ToString(Math.Round(iNb * 9 / 5 + 32, 2));
                    break;
                case 5:
                    label4.Text = Convert.ToString(Math.Round(iNb * 3.2808, 2));
                    break;
                case 6:
                    label4.Text = Convert.ToString(Math.Round(iNb * 0.3048, 2));
                    break;
                case 7:
                    label4.Text = Convert.ToString(Math.Round(iNb * 0.3937, 2));
                    break;
                case 8:
                    label4.Text = Convert.ToString(Math.Round(iNb * 2.54, 2));
                    break;
                case 9:
                    label4.Text = Convert.ToString(Math.Round(iNb * 0.264, 2));
                    break;
                case 10:
                    label4.Text = Convert.ToString(Math.Round(iNb * 3.785, 2));
                    break;
            }

        }

    }
}
