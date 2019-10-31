using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FormSimpson1tercioMultiple : Form
    {
        public FormSimpson1tercioMultiple()
        {
            InitializeComponent();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {

                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                int n = Convert.ToInt32(textBox3.Text);
                
                Simpson1tercioMultiple s1 = new Simpson1tercioMultiple();

                if (n % 2==0)
                {
                   
                    textBox8.Text = s1.integral(x1, x2, n).ToString();
                }
                else
                {
                    double resultado1, resultado2;
                    double h = (x2 - x1) / n;
                    Simpson3octavosSimple s3 = new Simpson3octavosSimple();
                    resultado1 = s1.integral(x1, (x2-(3*h)), n-3);
                    resultado2 = s3.integral((x2-(3*h)), x2);
                    double resultado = resultado1 + resultado2;
                    textBox8.Text = resultado.ToString();

                }
                
            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
