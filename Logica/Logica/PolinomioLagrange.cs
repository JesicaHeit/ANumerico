using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PolinomioLagrange
    {
        public double PoliL(double[] x, double[] y, int v)
        {

            double fvalor = 0;
            int n = x.Length;
            int[] lx = new int[n];
            int i = 0, grado = n - 1;


            while (i <= grado)
            {
                int j = 0;
                double L = 1;
                while (j <= n - 1)
                {
                    if (i != j)
                    {
                        L = L * ((v - x[j]) / (x[i] - x[j]));
                    }
                    j = j + 1;
                }
                fvalor = fvalor + (L * y[i]);
                i = i + 1;
            }
            return fvalor;
        }
    }
}
