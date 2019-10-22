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
    public partial class FormGaussJordan : Form
    {
        public FormGaussJordan()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Operaciones.Text != "")
            {
                Operaciones.Clear();
                Operaciones.Focus();
            }

            GaussJordan gauss = new GaussJordan();
            int cantelementos = int.Parse(textBox1.Text);
            int pointx = 30;
            int pointy = 70;
      
            panel2.Controls.Clear();

            for (int j=0; j< int.Parse(textBox1.Text);j++)
            {
                for (int i=0; i< int.Parse(textBox1.Text);i++)
                {
                    TextBox text = new TextBox();
                    string nombre = "txt" + j + i;
                    text.Name = nombre;
                    text.BackColor = Color.PaleVioletRed;
                    text.Location= new Point(pointx, pointy);
                    text.Size = new Size(60, 100);
                    panel2.Controls.Add(text);
                    pointy += 40;
                }
                
                pointx += 70;
                pointy = 70;
            }
            for (int u = 0; u < cantelementos; u++)
            {
                TextBox text = new TextBox();
                string nombre = "txt" + u;
                text.Name = nombre;
                text.BackColor = Color.Violet;
                text.Location = new Point(pointx, pointy);
                text.Size = new Size(60,100);
                panel2.Controls.Add(text);
                pointy += 40;
            }


        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Salida sali = new Salida();
            int cantelem = int.Parse(textBox1.Text);
            double [] vect = new double [cantelem];
            double[,] matriz = new double[cantelem, cantelem + 1];

            double[] v = new double[(cantelem * cantelem) + cantelem];
            int i = 0;
            foreach (TextBox txt in panel2.Controls.OfType<TextBox>())
            {
                v[i] = Convert.ToDouble(txt.Text);
                i++;
            }

            int xv = 0;
            for (int ym = 0; ym < cantelem + 1; ym++)
            {
                for (int xm = 0; xm < cantelem; xm++)
                {
                    matriz[xm, ym] = v[xv];
                    xv++;
                }
            }

            GaussJordan gauss = new GaussJordan();
            vect= gauss.Gauss(matriz,cantelem);
            for (int x=0; x< cantelem; x++)
            {
                Operaciones.Text += "Valor x" + x + " : " + vect[x] + Environment.NewLine;
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
