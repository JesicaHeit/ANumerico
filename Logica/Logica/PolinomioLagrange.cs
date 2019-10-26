using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PolinomioLagrange
    {
        public double PoliL(double[] x, double[] y, int v, int grado)
        {

            double fvalor = 0;
            int[] lx = new int[grado];
            int i = 0, n = grado;


            while (i <= n - 1)
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
