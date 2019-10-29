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

        private void uNIDADN2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metodoGaussSeidelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGaussSeidel form = new FormGaussSeidel();
            form.Owner = this;
            form.ShowDialog();
        }

        private void RegresionLinealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegresionLineal form = new FormRegresionLineal();
            form.Owner = this;
            form.ShowDialog();

        }

        private void RegresionPolinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegresionPolinomial form = new FormRegresionPolinomial();
            form.Owner = this;
            form.ShowDialog();
        }

        private void PolinomioDeLagrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPolinomioLagrange form = new FormPolinomioLagrange();
            form.Owner = this;
            form.ShowDialog();
        }

        private void TrapecioSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrapecioSimple form = new FormTrapecioSimple();
            form.Owner = this;
            form.ShowDialog();
        }

        private void TrapecioMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrapecioMultiple form = new FormTrapecioMultiple();
            form.Owner = this;
            form.ShowDialog();
        }

        private void Simpson13SimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSimpson1TercioSimple form = new FormSimpson1TercioSimple();
            form.Owner = this;
            form.ShowDialog();
        }

        private void Simpson13MultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSimpson1tercioMultiple form = new FormSimpson1tercioMultiple();
            form.Owner = this;
            form.ShowDialog();
        }

        private void Simpsopn38SimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSimpson3OctavosSimple form = new FormSimpson3OctavosSimple();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
