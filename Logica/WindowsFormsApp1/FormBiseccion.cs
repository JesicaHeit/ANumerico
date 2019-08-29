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
    public partial class FormBiseccion : Form
    {
        public FormBiseccion()
        {
            InitializeComponent();
            textBox3.Text = 100.ToString();
            textBox4.Text = (0.0001).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                Biseccion biseccion = new Biseccion();
                Salida salida = new Salida();
                salida = biseccion.MBiseccion(x1, x2);


                textBox8.Text = salida.Raiz.ToString();
                textBox7.Text = salida.NroIteraciones.ToString();
                textBox6.Text = salida.ErrorRelativo.ToString();
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
