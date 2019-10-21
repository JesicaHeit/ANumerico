using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRegresionLineal : Form
    {
        public FormRegresionLineal()
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

            //GaussJordan gauss = new GaussJordan();
            int cantelementos = int.Parse(textBox1.Text);
            int pointx = 30;
            int pointy = 70;

            panel2.Controls.Clear();

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    TextBox text = new TextBox();
                    string nombre = "txt" + j + i;
                    text.Name = nombre;
                    text.BackColor = Color.PaleVioletRed;
                    text.Location = new Point(pointx, pointy);
                    text.Size = new Size(60, 100);
                    panel2.Controls.Add(text);
                    pointy += 40;
                }

                pointx += 70;
                pointy = 70;
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           // Salida sali = new Salida();
            int cantelem = int.Parse(textBox1.Text);
            double[] vect = new double[cantelem];
            double[,] matriz = new double[cantelem, 2];

            double[] v = new double[(cantelem * 2) + cantelem];
            int i = 0;
            foreach (TextBox txt in panel2.Controls.OfType<TextBox>())
            {
                v[i] = Convert.ToDouble(txt.Text);
                i++;
            }

            int xv = 0;
            for (int ym = 0; ym < 2; ym++)
            {
                for (int xm = 0; xm < cantelem; xm++)
                {
                    matriz[xm, ym] = v[xv];
                    xv++;
                }
            }

            double xdos = 0;
            double sumxpory = 0;
            double sumx = 0;
            double sumy = 0;
            double[] vectoruno = new double[cantelem];
            double[] vectordos = new double[cantelem];
            for (int t = 0; t<cantelem;t++)
            {
                //filas cantelementos
                vectoruno[t] = matriz[t, 1]; //X
                sumx = sumx + vectoruno[t];
                vectordos[t] = matriz[t, 2]; //Y
                sumy = sumy + vectordos[t];
                sumxpory = sumxpory + (vectoruno[t] + vectordos[t]);
                xdos = Math.Pow(vectoruno[t], 2);
                //vectores con elementos formados. x e y.

            }
            double promy = 0;
            double promx = 0;
            promy = sumy / cantelem;
            promx = sumx / cantelem;

            double a1 = 0;
            double a0 = 0;

            a1 = ((cantelem * sumxpory) - (sumx * sumy)) / ((cantelem * xdos) - (Math.Pow(xdos,2)));
            a0 = promy - (a1 * promx);



            /*
            for (int x = 0; x < cantidadElementos; x++)
            {
                Operaciones.Text += "Valor x" + x + " : " + vect[x] + Environment.NewLine;
            }*/


            //GaussJordan gauss = new GaussJordan();
            //vect = gauss.Gauss(matriz, cantelem);
            /*for (int x = 0; x < cantelem; x++)
            {
                Operaciones.Text += "Valor x" + x + " : " + vect[x] + Environment.NewLine;
            }*/
        }
    }
}
