using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GaussJordan
    {
        public Salida Gauss (decimal[,] matriz)
        {
            Salida salida = new Salida();
            int tamañomatriz = matriz.GetUpperBound(1);
            int pivote = 0;
            for (int i=0; i<=tamañomatriz; i++)
            {
                if (matriz[i,i]==0)
                {
                    salida.ErrorMsje = "No es posible resolver la ecuacion"; 
                }
                else
                {
                    if (matriz[i,i]!=1)
                    {
                        decimal pivotedivisor = matriz[i, i];
                        for (int col=0; col<=tamañomatriz;col++)
                        {
                            matriz[i, col] = matriz[i, col] / pivotedivisor;
                        }
                    }
                    for (int renglon=0; renglon<=tamañomatriz;renglon++)
                    {
                        if (renglon!=pivote)
                        {
                            decimal val0 = Convert.ToDecimal(matriz[renglon, i]);
                            for (int columna=0; columna<=tamañomatriz;columna++)
                            {
                                matriz[renglon, columna] = matriz[renglon, columna] - ( matriz[i, columna]* val0);
                            }
                        }
                    }
                }
            }
            pivote++;
            return salida;
        }
    }
}
