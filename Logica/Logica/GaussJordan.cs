using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GaussJordan
    {
        public double[] Gauss(double[,] matriz, int tamaño)
        {
            double[] v = new double[tamaño];

            for (int i = 0; i <= tamaño - 1; i++)
            {
                double coeficiente = matriz[i, i];
                for (int x = 0; x <= tamaño; x++)
                {
                    matriz[i, x] = matriz[i, x] / coeficiente;
                }
                for (int y = 0; y <= tamaño - 1; y++)
                {
                    if (i != y)
                    {
                        coeficiente = matriz[y, i];
                        for (int k = 0; k <= tamaño; k++)
                        {
                            matriz[y, k] = matriz[y, k] - (coeficiente * matriz[i, k]);
                        }
                    }
                }
            }
            for (int k = 0; k <= tamaño - 1; k++)
            {
                v[k] = matriz[k, tamaño];
            }
            return v;
        }

    }
}

