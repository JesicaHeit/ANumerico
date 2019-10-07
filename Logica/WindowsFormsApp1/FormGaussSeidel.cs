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
    public partial class FormGaussSeidel : Form
    {
        public int cantidadElementos { get; set; }
        public GaussSeidel GSeidel { get; set; }

        public FormGaussSeidel()
        {
            InitializeComponent();
        }

        public void FormGaussSeidel_Load(object sender, EventArgs e)
        {
           GaussSeidel newgaus = new GaussSeidel();
           label4.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Operaciones.Text != "")
            {
                Operaciones.Clear();
                Operaciones.Focus();
            }

            GSeidel = new GaussSeidel();
            int cantidadElementos = int.Parse(textBox1.Text);
            GSeidel.cantidadElementos = int.Parse(textBox1.Text);
            cantidadElementos = GSeidel.cantidadElementos;

            int pointx = 70;
            int pointy = 70;

            panel2.Controls.Clear();

            for (int j = 0; j < int.Parse(textBox1.Text); j++)
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    TextBox text = new TextBox();
                    string nombre = "txt" + j + i;
                    text.Name = nombre;
                    text.BackColor = Color.PaleVioletRed;
                    text.Location = new Point(pointx, pointy);
                    text.Size = new Size(40, 40);
                    panel2.Controls.Add(text);
                    pointy += 40;
                }

                pointx += 70;
                pointy = 70;
            }
           /* for (int u = 0; u < cantidadElementos; u++)
            {
                TextBox text = new TextBox();
                string nombre = "txt" + u;
                text.Name = nombre;
                text.BackColor = Color.Violet;
                text.Location = new Point(pointx, pointy);
                text.Size = new Size(40, 40);
                panel2.Controls.Add(text);
                pointy += 40;
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidadElementos = int.Parse(textBox1.Text);
            double[] vect;
            double[,] matriz2 = new double[cantidadElementos, cantidadElementos + 1];

            double[] v = new double[(cantidadElementos * cantidadElementos) + cantidadElementos];
            int i = 0;
            foreach (TextBox txt in panel2.Controls.OfType<TextBox>())
            {
                v[i] = Convert.ToDouble(txt.Text);
                i++;
            }
            int xv = 0;
            for (int ym = 0; ym < cantidadElementos + 1; ym++)
            {
                for (int xm = 0; xm < cantidadElementos; xm++)
                {
                    matriz2[xm, ym] = v[xv];
                    xv++;
                }
            }

            vect = GSeidel.MGaussSeidel(matriz2);
            for (int x = 0; x < cantidadElementos; x++)
            {
                Operaciones.Text += "Valor x" + x + " : " + vect[x] + Environment.NewLine;
            }
            label4.Visible = true;
            label4.Size = new Size(60, 30);
            label4.Text = $"Cantidad de iteraciones: {GSeidel.iteracionesUtilizadas}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
