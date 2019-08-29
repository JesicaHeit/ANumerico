﻿using System;
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x1 = Convert.ToDouble(textBox1.Text);
                NewtonRaphson newton = new NewtonRaphson();
                Salida salida = new Salida();
                salida = newton.NRaphson(x1);


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
