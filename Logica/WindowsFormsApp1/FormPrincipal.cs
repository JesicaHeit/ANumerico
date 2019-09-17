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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BISECCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBiseccion form = new FormBiseccion();
            form.Owner = this;
            form.ShowDialog();
        }

        private void REGLAFALSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReglaFalsa form = new FormReglaFalsa();
            form.Owner = this;
            form.ShowDialog();
        }

        private void NEWTONRAPHSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewtonRaphson form = new FormNewtonRaphson();
            form.Owner = this;
            form.ShowDialog();
        }

        private void SECANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecante form = new FormSecante();
            form.Owner = this;
            form.ShowDialog();
        }

        private void UNIDADN1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MetodoGaussJordanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGaussJordan form = new FormGaussJordan();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
