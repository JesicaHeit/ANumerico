using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GaussJordan
    {
        public double[] Calcular(double[,] M, int tamaño) //matriz llena como parámetro
        {
            double [] V = new double [tamaño];
            for (int i = 0; i <= tamaño - 1; i++)
            {
                double coeficiente = M[i, i];
                for (int j = 0; j <= tamaño; j++)
                {
                    M[i, j] = M[i, j] / coeficiente;
                }
                for (int j = 0; j <= tamaño - 1; j++)
                {
                    if (i != j)
                    {
                        coeficiente = M[j, i];
                        for (int k = 0; k <= tamaño; k++)
                        {
                            M[j, k] = M[j, k] - (coeficiente * M[i, k]);
                        }
                    }
                }
            }
            for (int i = 0; i <= tamaño - 1; i++)
            {
                V[i] = M[i, tamaño];
            }
            return V;
        }

    }
}

