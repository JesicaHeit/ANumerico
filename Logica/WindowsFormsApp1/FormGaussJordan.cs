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
            GaussJordan gauss = new GaussJordan();
            int cantelementos = int.Parse(textBox1.Text);
            int pointx = 30;
            int pointy = 40;
      
            panel2.Controls.Clear();

            for (int j=0; j< int.Parse(textBox1.Text);j++)
            {
                for (int i=0; i< int.Parse(textBox1.Text);i++)
                {
                    TextBox text = new TextBox();
                    string nombre = "txt" + j + i;
                    text.Name = nombre;
                    text.Location= new Point(pointx, pointy);
                    panel2.Controls.Add(text);
                    pointy += 20;
                }
                
                pointx += 100;
                pointy = 40;
            }
            for (int u = 0; u < cantelementos; u++)
            {
                TextBox text = new TextBox();
                string nombre = "txt" + u;
                text.Name = nombre;
                text.Location = new Point(pointx, pointy);
                panel2.Controls.Add(text);
                pointy += 20;
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            int cantelem = int.Parse(textBox1.Text);
            decimal[,] matriz = new decimal[cantelem, cantelem + 1];

            decimal[] v = new decimal[(cantelem * cantelem) + cantelem];
            int i = 0;
            foreach (TextBox txt in panel2.Controls.OfType<TextBox>())
            {
                v[i] = Convert.ToDecimal(txt.Text);
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
            gauss.Gauss(matriz);

        }
    }
}
