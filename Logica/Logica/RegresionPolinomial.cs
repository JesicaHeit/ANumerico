using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class RegresionPolinomial
    {
        public double ST { get; set; }
        public double SR { get; set; }
        public double[] RegresionP(double[] x, double[] y, int cantp, int grados)
        {
            GaussJordan gauss = new GaussJordan();
            double sumx = 0;
            double sumy = 0;
            double[,] M = new double[grados + 1, grados+2];
            double[] Result;
            for (int i = 0; i < cantp; i++)
            {
                sumx +=  x[i];
                sumy +=  y[i];
                for (int j = 0; j< grados+1; j++)
                {
                    for (int k = 0; k < grados+1; k++)
                    {
                        M[j, k] +=  Math.Pow(x[i], k + j);
                    }
                    M[j, grados + 1] += (y[i] * Math.Pow(x[i], j));
                }
            }

            Result= gauss.Gauss(M, grados + 1);
            double S = 0;
            for (int di = 0; di < cantp; di++)
            {
                ST = ST + Math.Pow((sumy / cantp) - y[di], 2);
                S = 0;
                for (int j = 0; j < grados + 1; j++)
                {
                    S = S + (Result[j] * Math.Pow(x[di], j));
                }
                SR = SR + Math.Pow(S - y[di], 2);
            }
            return Result;
                
        }
    }
}
