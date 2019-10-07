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
    }
}
