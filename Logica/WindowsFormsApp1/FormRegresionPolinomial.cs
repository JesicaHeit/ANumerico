using Logica;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormRegresionPolinomial : Form
    {
        public FormRegresionPolinomial()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RegresionPolinomial regresionp = new RegresionPolinomial();
            int cantelem = int.Parse(textBox1.Text);
            int grado = int.Parse(textBox2.Text);
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
            for (int t = 0; t < cantelem; t++)
            {
                //filas cantelementos
                vectoruno[t] = matriz[t, 0]; //X
                sumx = sumx + vectoruno[t];
                vectordos[t] = matriz[t, 1]; //Y
                sumy = sumy + vectordos[t];
                sumxpory = sumxpory + (vectoruno[t] * vectordos[t]);
                xdos = xdos + Math.Pow(vectoruno[t], 2);
                //vectores con elementos formados. x e y.

            }

            vect = regresionp.RegresionP(vectoruno, vectordos, cantelem, grado);
            for (int x = 0; x < grado+1; x++)
            {
                Operaciones.Text += "Valor A" + x + " : " + vect[x] + Environment.NewLine;
            }

            if (regresionp.ST!=0)
            {
                double corr = Math.Sqrt(Math.Abs((regresionp.ST - regresionp.SR) / regresionp.ST)) * 100;
                Operaciones.Text += "Valor del coeficiente de correlacion"  + " : " + corr + Environment.NewLine;
                Operaciones.Text += "Valor de ST" + ":" + regresionp.ST + Environment.NewLine;
                Operaciones.Text += "Valor de SR" + ":" + regresionp.SR + Environment.NewLine;
            }           
            else if (regresionp.ST == 0)
            {
                Operaciones.Text += "Error, Division por 0";
            }
            else
            {
                Operaciones.Text += "No se puede resolver por este metodo";
            }

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Operaciones.Text != "")
            {
                Operaciones.Clear();
                Operaciones.Focus();
            }

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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
