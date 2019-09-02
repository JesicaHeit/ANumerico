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
    public partial class FormNewtonRaphson : Form
    {
        public FormNewtonRaphson()
        {
            InitializeComponent();
            textBox3.Text = 100.ToString();
            textBox4.Text = (0.0001).ToString();
            textBox5.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x1 = Convert.ToDouble(textBox1.Text);
                NewtonRaphson newton = new NewtonRaphson();
                Salida salida = new Salida();
                salida = newton.NRaphson(x1);


                if (salida.Raiz.ToString() == "NaN" || salida.ErrorRelativo.ToString() == "NaN")
                {
                    
                    salida.ErrorMsje = "Mal elegidos los extremos";
                    
                }
                else
                {
                    textBox8.Text = Convert.ToDecimal(salida.Raiz).ToString();
                    textBox7.Text = salida.NroIteraciones.ToString();
                    textBox6.Text = Convert.ToDecimal(salida.ErrorRelativo).ToString();
                }

                textBox5.Visible = true;
                textBox5.Text = salida.ErrorMsje;
                if (salida.ErrorMsje != null)
                {
                    textBox8.Text = 0.ToString();
                    textBox7.Text = 0.ToString();
                    textBox6.Text = 0.ToString();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
